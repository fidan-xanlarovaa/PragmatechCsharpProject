using PhoneBook.Entities_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Business_.Services
{
    public interface IUserService
    {
        int Login(User entity);
    }
}
