using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Core.Repository
{
    public interface IUserRepository
    {
        int Login(User entity);
    }
}

