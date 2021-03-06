using CsvHelper;
using PhoneBook.Business_.Enums;
using PhoneBook.Core_.Repository;
using PhoneBook.Entities_;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneBook.Business_.Services
{
    public class ContactService : IContactService
    {


        private readonly IContactRepository _contactRepository;
        private static string _exportPath;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
            _exportPath = @"C:\Users\HP\source\repos\PragmatechCsharpProject\DesktopApplications\Week15\PhoneBook.Core_\Context";
        }
        public int Add(Contact entity)
        {
            int result = 0;

            if (ContactValidations(entity))
            {
                result = _contactRepository.Add(entity);
            }
            else
            {
                result = (int)ResultCodeEnums.ModelStateNoValid;
            }

            return result;
        }

        public int Delete(Guid id)
        {
            int result = 0;

            if (DeleteContactValidations(id))
            {
                result = _contactRepository.Delete(id);
            }
            else
            {
                result = (int)ResultCodeEnums.ModelStateNoValid;
            }

            return result;
        }

        public List<Contact> GetAll()
        {
            return _contactRepository.GetAll();
        }

        public int Update(Contact entity)
        {
            int result;

            if (UpdateContactValidations(entity))
            {
                result = _contactRepository.Update(entity);
            }

            else
            {
                result = (int)ResultCodeEnums.ModelStateNoValid;
            }

            return result;
        }


        public int ExportXML()
        {
            int result = 0;
            try
            {
                var entities = _contactRepository.GetAll();
                XDocument document = new XDocument(
                    new XDeclaration("1.0.0.1", "UTF-8", "yes"),
                    new XElement("Contacts", entities.Select(i =>
                        new XElement("Contact",
                            new XElement("Id", i.Id),
                            new XElement("Name", i.Name),
                            new XElement("Surname", i.Surname),
                            new XElement("Address", i.Address),
                            new XElement("Description", i.Description),
                            new XElement("Email", i.Email),
                            new XElement("Website", i.Website),
                            new XElement("Number1", i.Number1),
                            new XElement("Number2", i.Number2),
                            new XElement("Number3", i.Number3)))));

                document.Save(_exportPath + "Contacts.xml");
                result = 1;
            }
            catch (Exception)
            {
                result = 0;
            }

            return result;
        }

        public int ExportCSV()
        {
            int result = 0;
            try
            {
                var entities = _contactRepository.GetAll();

                using (var writer = new StreamWriter(_exportPath + "Contacts.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<Contact>();
                    csv.NextRecord();
                    foreach (var record in entities)
                    {
                        csv.WriteRecord(record);
                        csv.NextRecord();
                    }
                }

                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
            }

            return result;
        }

        public int ExportJSON()
        {
            int result = 0;
            try
            {
                var entities = _contactRepository.GetAll();

                SerializeObjToJson("Contacts.json", entities);

                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
            }

            return result;
        }


        public int ImportJson(string path)
        {
            try
            {
                if (PathValidations(path)) 
                {
                    string data = File.ReadAllText(path);
                    var contacts = JsonSerializer.Deserialize<List<Contact>>(data);

                    _contactRepository.AddRange(contacts);

                    return 1;
                }

                else
                {
                    return 0;
                }
                
            }
            catch
            {
                return 0;
            }
            finally
            {
                GetAll();
            }
        }



        #region helper Methods

        private static void SerializeObjToJson<T>(string fileName, List<T> data)
        {
            // using System.Text.Json;
            var json = JsonSerializer.Serialize(data, typeof(List<T>),
                new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges
                        .All),
                    WriteIndented = true
                });

            File.WriteAllText(_exportPath + fileName, json);
        }

        private bool ContactValidations(Contact entity)
        {
            return !string.IsNullOrEmpty(entity.Name)
                   && !string.IsNullOrEmpty(entity.Surname)
                   && !string.IsNullOrEmpty(entity.Number1);
        }

        private bool PathValidations(string path)
        {
            return !string.IsNullOrEmpty(path);
        }

        private bool UpdateContactValidations(Contact entity)
        {
            return entity.Id != Guid.Empty
                   && !string.IsNullOrEmpty(entity.Name)
                   && !string.IsNullOrEmpty(entity.Surname)
                   && !string.IsNullOrEmpty(entity.Number1);
        }
        private bool DeleteContactValidations(Guid id)
        {
            return id != Guid.Empty;
        }


        #endregion


    }
}
