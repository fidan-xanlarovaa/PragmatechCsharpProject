using Blog.Shared.Localization;
using Blog.Shared.Utilities.ComplexTypes;
using Blog.Shared.Utilities.Concrete;
using Blog.Shared.Utilities.Results.Abstract;


namespace Blog.Shared.Utilities.Abstract
{
    public abstract class BaseServiceResult
    {
        protected IResult<TResult> NotFound<TResult>(params string[] errors)
        {
            return new Result<TResult>(ServiceResultCode.NotFound, default(TResult), errors);
        }

        protected IResult<TResult> Ok<TResult>(TResult entity)
        {
            return new Result<TResult>(ServiceResultCode.Ok, entity);
        }

        protected IResult<TResult> Created<TResult>(TResult entity)
        {
            return new Result<TResult>(ServiceResultCode.Created,BaseLocalization.CreatedSuccessfully,entity);
        }

        protected IResult<TResult> Updated<TResult>(TResult outPut)
        {
            return new Result<TResult>(ServiceResultCode.Updated, BaseLocalization.UpdatedSuccesfully, outPut);
        }
       
        protected IResult<TResult> Deleted<TResult>(TResult output)
        {
            return new Result<TResult>(ServiceResultCode.Deleted, BaseLocalization.DeletedSuccessfully, output);
        }

        protected IResult<TResult> Error<TResult>(params string[] errors)
        {
            return new Result<TResult>(ServiceResultCode.Error, default(TResult), errors);
        }
    }
}
