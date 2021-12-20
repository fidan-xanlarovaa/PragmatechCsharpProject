using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Shared.Utilities.Abstract
{
    /// <summary>
    /// 
    ///  out key wordu byrda var deye biz burda mecburi bir deyer vermeli deyilik. Bele yaziriq cunki, biz burda 1 entity ve ya list de qytara bilerik.
    ///  Onceden tam deqiq ne olduqunu bildirmediyimize goe bu formada istifade edirik
    ///  
    /// </summary>
     
    public interface IDataResult<out T> : IResult
    {
        public T Data { get; }
    }
}
