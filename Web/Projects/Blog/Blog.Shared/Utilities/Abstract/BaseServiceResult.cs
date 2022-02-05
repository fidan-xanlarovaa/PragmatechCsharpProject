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
    }
}
