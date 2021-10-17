using PhoneBook.Business.Enums;
using PhoneBook.Core.Repository;
using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int Login(User entity)
        {
            int result = 0;

            if (LoginValidations(entity))
            {
                result = _userRepository.Login(entity);
            }
            else
            {
                result = (int)ResultCodeEnums.ModelStateNoValid;
            }

            return result;
        }


        private bool LoginValidations(User entity)
        {
            return !string.IsNullOrEmpty(entity.Username)
                   && !string.IsNullOrEmpty(entity.Password);
        }
    }
}
