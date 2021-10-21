using PhoneBook.Entities_;
using System;

using PhoneBook.Core_.Context;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Core_.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PhoneBookDbContext _context;
        public UserRepository()
        {
            _context = new PhoneBookDbContext();
        }

        public int Login(User entity)
        {
            return _context.Users.Count(i => i.Username == entity.Username && i.Password == entity.Password);
        }
    }
}
