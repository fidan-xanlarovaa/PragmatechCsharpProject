using Blog.Data.Abstract;
using Blog.Entities;
using Blog.Entities.Dtos;
using Blog.Services.Abstract;
using Blog.Shared.Utilities.Abstract;
using Blog.Shared.Utilities.ComplexTypes;
using Blog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Concret
{
    public class PostManager : IPostService
    {
        private readonly IUnitOfWork _iunitofwork;

        public PostManager(IUnitOfWork iunitofwork)
        {
            _iunitofwork = iunitofwork;
        }
        public async Task<IResult> AddAsync(PostAddDto dto, string createdByName)
        {
            var entity = new Post(dto.CategoryId, dto.Content, dto.Date, dto.Note, dto.SeoAuthor, dto.SeoDescription, dto.SeoTags, dto.Thumbnail, dto.Title, dto.UserId);
            entity.SetIsActive(dto.IsActive);
            entity.SetCreatedByName(createdByName);

            await _iunitofwork.Posts.AddAsync(entity);

            var result = await _iunitofwork.SaveChangesAsync();

            if (result > 0)
            {
                return new Result(resultStatus: ResultStatus.Success, $"{entity.Title} created");
            }

            return new Result(resultStatus: ResultStatus.Error, $"{entity.Title} is not created");

        }
        public async Task<IResult> DeleteAsync(int id, string modifiedByName)
        {
            var entity = await _iunitofwork.Posts.GetAsync(p => p.Id == id);

            if (entity is null)
            {
                return new Result(ResultStatus.Error, "not found");

            }

            entity.SetIsDeleted(false);
            entity.SetModifiedByName(modifiedByName);

            await _iunitofwork.Posts.UpdateAsync(entity);

            var result = await _iunitofwork.SaveChangesAsync();

            if (result > 0) return new Result(ResultStatus.Success, $"{entity.Title} removed");
            return new Result(ResultStatus.Error, $"{entity.Title} not removed");
        }

        public async Task<IDataResult<PostListDto>> GetAllAsync()
        {
            var entities = await _iunitofwork.Posts.GetAllAsync(null, p=>p.Comments);

            if(entities.Count>-1)
            {
                var dto = new PostListDto()
                {
                    Entities = entities,
                    ResultStatus = ResultStatus.Success


                };
                return new DataResult<PostListDto>(resultStatus: ResultStatus.Success, dto);
            }

            return new DataResult<PostListDto>(resultStatus: ResultStatus.Success, null,"not found");
        }

        public async Task<IDataResult<PostListDto>> GetAllByNonDeletedAsync()
        {
            var entities = await _iunitofwork.Posts.GetAllAsync(p => !p.IsDeleted, p => p.Comments);

            if (entities.Count > -1)
            {
                var dbo = new PostListDto
                {
                    Entities = entities,
                    ResultStatus = ResultStatus.Success
                };
                return new DataResult<PostListDto>(resultStatus: ResultStatus.Success, dbo);
            }

            return new DataResult<PostListDto>(resultStatus: ResultStatus.Success, null,"not found");

        }

        public async Task<IDataResult<PostDto>> GetAsync(int id)
        {
            var entity = await _iunitofwork.Posts.GetAsync(i => i.Id == id, p => p.Comments); 

            if (entity != null)
            {
                var dto = new PostDto()
                {
                    Entity = entity,
                    ResultStatus = ResultStatus.Success
                };
                return new DataResult<PostDto>(resultStatus: ResultStatus.Success, dto);
            }
            return new DataResult<PostDto>(resultStatus: ResultStatus.Error, null, "not found");

        }

        public async Task<IResult> HardDeleteAsync(int id)
        {
            var entity = await _iunitofwork.Posts.GetAsync(p => p.Id == id);

            if (entity is null)
            {
                return new Result(ResultStatus.Error, "not found");

            }

            await _iunitofwork.Posts.DeleteAsync(entity);

            var result = await _iunitofwork.SaveChangesAsync();

            if (result > 0)
            {
                return new Result(ResultStatus.Success, $"{entity.Title} removed");
            }

            return new Result(ResultStatus.Error, $"{entity.Title} not removed");

        }

        public async Task<IResult> UpdateAsync(PostUpdateDto dto, string createdByName)
        {
            var entity = await _iunitofwork.Posts.GetAsync(p => p.Id == dto.Id);

            if(entity is null)
            {
                return new Result(ResultStatus.Error, $"{dto.Id} not found");
            }
           
            entity.Title = dto.Title;
            entity.CategoryId = dto.CategoryId;
            entity.Content = dto.Content;
            entity.Date = dto.Date;
            entity.SeoAuthor = dto.SeoAuthor;
            entity.SeoDescription = dto.SeoDescription;
            entity.SeoTags = dto.SeoTags;
            entity.Thumbnail = dto.Thumbnail;
            entity.UserId = dto.UserId;

            await _iunitofwork.Posts.UpdateAsync(entity);

            var result = await _iunitofwork.SaveChangesAsync();

            if (result > 0)
            {
                return new Result(ResultStatus.Success, $"{entity.Title} modified");
            }

            return new Result(ResultStatus.Error, $"{entity.Title} not modified");

        }
    }
}
