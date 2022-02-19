using AutoMapper;
using Blog.Data.Abstract;
using Blog.Entities.Concrete;
using Blog.Entities.Dtos.User;
using Blog.Services.Abstract;
using Blog.Shared.Helpers;
using Blog.Shared.Localization;
using Blog.Shared.Utilities.Abstract;
using Blog.Shared.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Concret
{
    public class UserManager : BaseServiceResult, IUserService
    {
        /// <summary>
        /// eslinde identity bize ozu service verir, lakin onu bir basa UI layerinde verdiyi ucun, bu bizim proyektin 
        /// qurulusunu pozur. Buna gore de biz yeniden burda yaziriq. Buna gore de biz indi burda hemen metodlari inject edib istifade edeceyik.
        /// </summary>
        
        #region fields

        private readonly UserManager<User> _identityUserManager; //Bu bizim yaratdiqimiz UserManager deyi, Identitinin manageridi
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileHelper _fileHelper;
        private const string DefaultUserAvatarFileName = "Users/defaultUser.png";


        #endregion


        #region ctor

        public UserManager(UserManager<User> identityuserManager, IMapper mapper = null, IUnitOfWork unitOfWork = null, IFileHelper fileHelper = null)
        {
            _identityUserManager = identityuserManager;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _fileHelper = fileHelper; // constructora inject eledikden sonra bunu hemcinin, shared layerinde extensionun yazmaliyiq ki,
                                      // instancesin yaradib versin
        }
        #endregion

        #region QUERY


        public async Task<IResult<IList<UserDto>>> GetAllAsync()
        {
            var entities = await _identityUserManager.Users.ToListAsync();
            if (entities is null)
                return NotFound<IList<UserDto>>(BaseLocalization.NoDataAvailableOnRequest);
            var outputDto = _mapper.Map<IList<UserDto>>(entities);
            return Ok(outputDto);
        }
        #endregion

        #region CRUD

        public async Task<IResult<UserDto>> AddAsync(UserAddDto dto, string createdByName)
        {
            bool isAlreadyRegister = await _unitOfWork.Users.AnyAsync(i => i.NormalizedEmail == dto.Email.ToUpper() // NormalizedEmail o demekdirki yeni biz databasedde saxlayanda her sey standart olsun deye ToUpper edib saxlayiriq, eks halda bize cox problem yaradar.
                                                                               || i.PhoneNumber == dto.PhoneNumber
                                                                               || i.NormalizedUserName == dto.UserName.ToUpper());
            if (isAlreadyRegister)
            {
                return Error<UserDto>(BaseLocalization.NoDataAvailableOnRequest); //(BaseLocalization.AlreadyExistUser);
            }

            var entity = _mapper.Map<User>(dto);

            if (dto.File is not null)
            {
                var uploadedResult = await _fileHelper.UploadImageAsync(dto.File, "Users", dto.UserName);
                if (!uploadedResult.IsSuccess)
                {
                    return Error<UserDto>(uploadedResult.Errors.ToArray());
                }

                entity.Avatar = uploadedResult.Data.FullName; // database de saxlanilaxaq avatar in pathi
            }
            else
            {
                entity.Avatar = DefaultUserAvatarFileName;
            }


            var identityResult = await _identityUserManager.CreateAsync(entity, dto.Password); // butun map ve file isleri bitenden
                                                                                               // sonra Useri create edirik

            if (!identityResult.Succeeded)
            {
                _fileHelper.DeleteImage(entity.Avatar); // eger create olunmadisa user, onun seklini de silirik
                var identityErrors = identityResult.Errors.Select(i => i.Description).ToArray();
                return Error<UserDto>(identityErrors);
            }

            var outputDto = _mapper.Map<UserDto>(entity); //yeniden Usedto map edirik ki, duzgun formad agorsensin cedvelde
            return Created(outputDto); // ve son olaraqda standart formamiz olan BaseServiceResult -daki Create metodu ile
                                       // return edirik
        }
        
    


        public async Task<IResult<UserUpdateDto>> GetUpdateDtoAsync(int id)
        {
            var entity = await _identityUserManager.FindByIdAsync(id.ToString());
            if (entity is null)
                return NotFound<UserUpdateDto>(BaseLocalization.NoDataAvailableOnRequest);//(BaseLocalization.NotFoundCodeGeneralMessage);
            var outputDto = _mapper.Map<UserUpdateDto>(entity);
            return Ok(outputDto);
        }

        public async Task<IResult<UserDto>> UpdateAsync(UserUpdateDto dto, string modifiedByName)
        {
            var foundedEntity = await _identityUserManager.FindByIdAsync(dto.Id.ToString());
            if (foundedEntity is null)
                return Error<UserDto>(BaseLocalization.NoDataAvailableOnRequest);
            
            bool isAlreadyExistUser = await _unitOfWork.Users.AnyAsync(i => i.Id != foundedEntity.Id && i.NormalizedEmail == dto.Email.ToUpper()
                                                                            || i.Id != foundedEntity.Id && i.PhoneNumber == dto.PhoneNumber
                                                                            || i.Id != foundedEntity.Id && i.NormalizedUserName == dto.UserName.ToUpper());

            if (isAlreadyExistUser)
            {
                return Error<UserDto>(BaseLocalization.NoDataAvailableOnRequest); //(BaseLocalization.AlreadyExistUser);
            }

            var oldFileName = foundedEntity.Avatar;
            bool isNewFileUploaded = false;

            if (dto.File is not null)
            {
                var uploadedResult = await _fileHelper.UploadImageAsync(dto.File, "Users", dto.UserName);

                if (!uploadedResult.IsSuccess)
                {
                    return Error<UserDto>(uploadedResult.Errors.ToArray());
                }

                dto.Avatar = uploadedResult.Data.FullName;
                if (!string.Equals(oldFileName, DefaultUserAvatarFileName))
                {
                    isNewFileUploaded = true;
                }
            }
            var updatedEntity = _mapper.Map(dto, foundedEntity);
            var identityResult = await _identityUserManager.UpdateAsync(updatedEntity);

            if (!identityResult.Succeeded)
            {
                var identityErrors = identityResult.Errors.Select(i => i.Description).ToArray();
                return Error<UserDto>(identityErrors);
            }

            if (isNewFileUploaded)
            {
                _fileHelper.DeleteImage(oldFileName);
            }

            var outputDto = _mapper.Map<UserDto>(updatedEntity);
            return Updated(outputDto);
        }

        public async Task<IResult<UserDto>> DeleteAsync(int id, string modifiedByName)
        {

            var entity = await _identityUserManager.FindByIdAsync(id.ToString());
            if (entity is null)
                return NotFound<UserDto>(BaseLocalization.NoDataAvailableOnRequest); //(BaseLocalization.NotFoundCodeGeneralMessage);

            var identityResult = await _identityUserManager.DeleteAsync(entity);
            if (!identityResult.Succeeded)
            {
                var identityErrors = identityResult.Errors.Select(i => i.Description).ToArray();
                return Error<UserDto>(identityErrors);
            }
            var outputDto = _mapper.Map<UserDto>(entity);
            return Deleted(outputDto);
        }
        #endregion

    }
}
