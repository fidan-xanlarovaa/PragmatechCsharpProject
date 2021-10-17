using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Core.Repository
{
    public interface IContactRepository
    {
        int Add(Contact entity);
        int Update(Contact entity);

        List<Contact> GetAll();

        int Delete(Guid id);

    }
}
