using System;
using System.IO;
using System.Threading.Tasks;
using Blog.Shared.Extensions;
using Blog.Shared.Localization;
using Blog.Shared.Utilities.ComplexTypes;
using Blog.Shared.Utilities.Concrete;
using Blog.Shared.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Blog.Shared.Helpers
{
    public class FileHelper : IFileHelper
    {
        #region fields
        private readonly IWebHostEnvironment _env; // Bu bize rootumuz verir. Normalda eger by kodu MVC layerinde yazsaq hec bir problem olmaz,
                                                   // lakin burda yazanda tanimadiqi ucun problem cixir. Bu problemi hell etmek ucun de biz
                                                   // refference hissesine  <ItemGroup>
	                                               //                           <FrameworkReference Include = "Microsoft.AspNetCore.App" />
                                                   //                       </ ItemGroup > yaziriq. 
        private readonly string _wwwroot;
        private readonly string _imgFolder = "img";

        #endregion
        #region ctor

        public FileHelper(IWebHostEnvironment env)
        {
            _env = env;
            _wwwroot = _env.WebRootPath; // wwwrootun url-rin bize dinamik formada verir Bu url eslinde string kimi de qey ede bilerik,lakin sonra
                                         // yerni deyissek gelib deyismeli olacayiq deye bu formada yazmaq daha meqsede uyqundur.
        }
        #endregion
        #region Implementation of IFileHelper

        public async Task<IResult<FileDto>> UploadImageAsync(IFormFile file, string subDirectory, string otherName = default)
        {
            if (file.Length < 0)
            {
                return new Result<FileDto>(ServiceResultCode.BadFile, null, BaseLocalization.NoDataAvailableOnRequest);
            }

            var directory = $"{_wwwroot}/{_imgFolder}/{subDirectory}"; // sekili hansi foldere yerlesdir mes: wwwroot/img/User....

            if (!Directory.Exists(directory)) // eger movcud deyilse
            {
                Directory.CreateDirectory(directory);
            }

            otherName ??= string.Empty; //eger otherName yoxdursa faylin adi ele empty qalsin

            string fileName = Path.GetFileNameWithoutExtension(file.FileName); //faylin sonundaki uzantisiz adi ver, yeni saf adi ver.
                                                                               //meselen: apple.jpeg ->> apple 

            string fileExtension = Path.GetExtension(file.FileName); //faylin sonundaki uzantini ver meselen jpg jpeg png

            DateTime dateTime = DateTime.Now; //indiki tarix

            string uniqueFileName = $"{otherName}_{dateTime.FullDateTimeStringWithUnderscore()}{fileExtension}"; //Burda fayl adlari eyni halda
                                                                                                                 //olduqda problem yaranmasin deye
                                                                                                                 //adini deyisirik.
                                                                         //movcudFaylinAdi_yaranmaTarixi.uzantisi seklinde unique bir ad veririk.
                                                                         // dateTime.FullDateTimeStringWithUnderscore() evezine Guid.NewGuid() yazib
                                                                         // her faylin arkasina unique bir TOKEN ataraqda daha asan sekilde yaza
                                                                         // bilerdik.

            var path = Path.Combine(directory, uniqueFileName); //Faylin full pathini yaziriqc(combine edirik).
                                                                //mes: wwwroot/img/User/apple.jpeg

            await using (var stream = new FileStream(path, FileMode.Create)) //GabbageCollector bunu gorub clean etsin deye using
            {                                                                //bloklarindan istifade edirik. Her defe fayli close
                await file.CopyToAsync(stream);                              //elemekdense bu formada yaziriq ki isimiz biten kimi
            }                                                                //ozu avtomatik close elesin FileMode.Create demekdirki:
                                                                             //:get bu fayli create ele .
                                                                             

            // geriye hemiseki kimi Resultcode, Message ve FileDto  qaytariririq
            return new Result<FileDto>(ServiceResultCode.Ok,
                BaseLocalization.ImageUploadedSuccessfully, new FileDto() //BaseLocalization.
                {
                    FullName = $"{subDirectory}/{uniqueFileName}",
                    FileName = fileName,
                    Extension = fileExtension,
                    Path = path,
                    Size = file.Length
                });
        }

        public IResult<FileDto> DeleteImage(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                return new Result<FileDto>(ServiceResultCode.Error, null, BaseLocalization.NoDataAvailableOnRequest);

            var path = Path.Combine($"{_wwwroot}/{_imgFolder}", fileName); // fileName: user/apple.jpeg

            if (!File.Exists(path))// fayl movcud deyilse
                return new Result<FileDto>(ServiceResultCode.Error, null, BaseLocalization.NoDataAvailableOnRequest);

            var fileInfo = new FileInfo(path); //file haqqinda melumat aliriq

            var resultDto = new FileDto() //???????????Bu dto geri qaytaririqsa eger niye deleted folderinde saxlamiriq? Eger saxlamayacayiqsa niye geriye qaytaririrq?
            {
                FullName = fileName,
                Extension = fileInfo.Extension,
                Path = fileInfo.FullName,
                Size = fileInfo.Length
            };
            File.Delete(path);

            return new Result<FileDto>(ServiceResultCode.Ok, BaseLocalization.DeletedSuccessfully, resultDto); //BaseLocalization.DeletedSuccessfully
        }

        #endregion
    }
}