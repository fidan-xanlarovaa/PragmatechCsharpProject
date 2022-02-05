using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Shared.Utilities.ComplexTypes
{
    public enum ServiceResultCode
    {
        Ok = 100,
        Created = 101,
        Updated = 102,
        Deleted = 103,
        BadData = 200,
        BadFile = 201,
        NotFound = 202,
        Conflict = 203,
        License = 204,
        Error = 300,
        Redirect = 205
    }
}
