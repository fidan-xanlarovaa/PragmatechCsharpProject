using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Business.Services
{
    public interface IContactService
    {
        int Add(Contact entity);

        int Update(Contact entity);
        List<Contact> GetAll();

        int Delete(Guid id);

        int ExportXML();
        int ExportJSON();
        int ExportCSV();

        List<Contact> ImportJson();
    }
}
