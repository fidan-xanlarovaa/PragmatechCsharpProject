using PhoneBook.Entities_;
using System;

using PhoneBook.Core_.Context;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Core_.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PhoneBookADODbContext _context;
        public UserRepository()
        {
            _context = new PhoneBookADODbContext();
        }

        public int Login(User entity)
        {
            try
            {
                _context.Command = new SqlCommand("Select Count(*) from [User] where Usurname=@usurname and Password=@password",_context.Connection);
                _context.Command.Parameters.Add("@usurname", System.Data.SqlDbType.NVarChar).Value = entity.Username;
                _context.Command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = entity.Password;
                _context.SetConnection();
                _context.ReturnValues = (int)_context.Command.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _context.SetConnection();
            }

            return _context.ReturnValues;

        }
    }
}
