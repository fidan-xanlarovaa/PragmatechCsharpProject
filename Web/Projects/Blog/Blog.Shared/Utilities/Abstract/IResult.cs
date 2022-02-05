using Blog.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;

namespace Blog.Shared.Utilities.Results.Abstract
{
    /// <summary>
    /// 
    ///  out key wordu byrda var deye biz burda mecburi bir deyer vermeli deyilik. Bele yaziriq cunki, biz burda 1 entity ve ya list de qytara bilerik.
    ///  Onceden tam deqiq ne olduqunu bildirmediyimize goe bu formada istifade edirik
    ///  
    /// </summary>
    /// 
    public interface IResult<out T>
    {
        public T Data { get; }
        public ServiceResultCode ServiceResultCode { get; }
        public string Message { get; }
        public IList<string> Errors { get; }
        public bool IsSuccess { get; }
        public Exception Exception { get; }
    }
}