using Blog.Shared.Utilities.ComplexTypes;
using Blog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Shared.Utilities.Concrete
{
    public class Result<T> : IResult<T>

    {
        /// <summary>
        /// default(T) o demekdirki bura entity gondersek ve eger entity olmasa null gosterecek, eyni zamanda biz bura entity
        /// gondermek evezine null da yaza bilerik
        /// </summary>
        #region ctors
        public Result(ServiceResultCode serviceResultCode, T data = default(T), params string[] errors)
        {
            Data = data;
            ServiceResultCode = serviceResultCode;
            Errors = new List<string>(errors);
        }
        public Result(ServiceResultCode serviceResultCode, string message, T data = default(T), params string[] errors)
        {
            Data = data;
            Message = message;
            ServiceResultCode = serviceResultCode;
            Errors = new List<string>(errors);
        }
        #endregion

        public T Data { get; }
        public ServiceResultCode ServiceResultCode { get; }
        public string Message { get; }
        public IList<string> Errors { get; }
        public bool IsSuccess => !Errors.Any();
        public Exception Exception { get; }

    }
}
