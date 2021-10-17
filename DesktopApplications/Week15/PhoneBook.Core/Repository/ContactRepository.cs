using PhoneBook.Core.Context;
using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Core.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly PhoneBookDbContext _context;
        public ContactRepository()
        {
            _context = new PhoneBookDbContext();
        }
        #region Implementation of IContactRepository

        public int Add(Contact entity)
        {
            int result;
            try
            {
                _context.Contacts.Add(entity);
                _context.SaveChanges(_context.Contacts);
                result = 1;
            }
            catch (Exception)
            {
                result = 0;
                throw;
            }


            return result;
        }

        public int Delete(Guid id)
        {
            int result;
            try
            {
                var entity = _context.Contacts.Find(i => i.Id == id);

                if (entity == null)
                {
                    return result = 0;
                }

                _context.Contacts.Remove(entity);
                _context.SaveChanges(_context.Contacts);

                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
                throw;
            }

            return result;
        }

        public List<Contact> GetAll()
        {
            return _context.Contacts;
        }

        public int Update(Contact request)
        {
            int result;

            try
            {
                var contact = _context.Contacts.Find(i => i.Id == request.Id);

                if (contact == null)
                {
                    return result = 0;
                }
                contact.Name = request.Name;
                contact.Surname = request.Surname;
                contact.Email = request.Email;
                contact.Website = request.Website;
                contact.Address = request.Address;
                contact.Description = request.Description;
                contact.Number1 = request.Number1;
                contact.Number2 = request.Number2;
                contact.Number3 = request.Number3;

                _context.SaveChanges(_context.Contacts);

                result = 1;

            }
            catch (Exception)
            {
                result = 0;

                throw;
            }

            return result;

        }

        #endregion
    }
}
