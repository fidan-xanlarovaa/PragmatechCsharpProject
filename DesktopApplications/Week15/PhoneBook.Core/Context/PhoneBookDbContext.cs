using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Entities;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.Encodings.Web;
using System.Text.Unicode;





namespace PhoneBook.Core.Context
{
    public class PhoneBookDbContext
    {
        #region Constructors
        public PhoneBookDbContext()
        {
            _approot = AppRoot();
            _path = Directory.GetParent(_approot)?.FullName + "/PhoneBook.Core/Context";
            EnsureOrCreateDatabase();// eger Db bosdursa yeni instance yaradir
            if (_contacts != null)
            {
                _contacts = new List<Contact>();

            }

            if (_users != null)
            {
                _users = new List<User>();

            }
        }
        #endregion


        #region fields 

        private readonly string _path;
        private readonly string _approot;
        private const string usersJson = "/Users.json";
        private const string contactsJson = "/Contacts.json";
        private static List<Contact> _contacts;
        private static List<User> _users;

        #endregion

        #region props
        public List<User> Users { get => _users; set => _users = value; }
        public List<Contact> Contacts { get => _contacts; set => _contacts = value; }
        #endregion

        private static string AppRoot()
        {
            var exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath ?? string.Empty).Value;
            return appRoot;
        }


        private void EnsureOrCreateDatabase() // Database evez edecek json file-larin create edilmesi, Default olaraq evvecelden daxil edilmeli olan datalarin insert edilmesi 
        {

            var existDir = Directory.Exists(_path); //Cari path-de(unvanda) Directorinin(qovluqun) olub olmadiqini yoxlayiriq

            if (!existDir) Directory.CreateDirectory(_path); //eger yoxdursa yaradiriq

            //core.dll icerisinde yeni verdiyimiz pathde entitylerimize uyqun json file yardir.Bunu biz hal hazirda db kimi istifade edeceyik

            var path = Directory.GetParent(_approot)?.FullName;
            var coreDLL = $@"{path}\PhoneBook.Core\bin\Debug\net5.0\PhoneBook.Core.dll";

            var assembly = Assembly.LoadFile(coreDLL);
            var type = assembly.GetType("PhoneBook.Core.Context.PhoneBookDbContext");

            if (type !=null)
            {
                var propList = type.GetProperties().ToList();

                propList.ForEach(i =>
                {
                    var filePath = $"{_path}/{i.Name.ToString()}.json";
                    if (!Exists(filePath)) CreateFile(filePath);
                });

            }

            DataSeader();
        }

        private void DataSeader() //Db yaradilarken default elave edilecek datalar insert edilir
        {
            DeserializeObject();

            if (_users == null)
            {
                var user = new User { Username = "admin", Password = "admin123!" };

                var users = new List<User> { user };
                // new version
                SerializeObjToJson(_path + usersJson, users);
            }
        }

        private void DeserializeObject() //// Json data-nin Collectiona map edilmesi.
        {
            if (Exists($"{_path}{usersJson}"))
            {
                var jsonData = File.ReadAllText(_path + usersJson);
                _users = JsonConvert.DeserializeObject<List<User>>(jsonData);
            }

            if (Exists($"{_path}{contactsJson}"))
            {
                var jsonData = File.ReadAllText(_path + contactsJson);
                _contacts = JsonConvert.DeserializeObject<List<Contact>>(jsonData);
            }
        }

        /// <summary>
        ///     daxil edilen path-de T tipinde daxil edilen collection-nin json-a map edilmesi
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="data"></param>
        private static void SerializeObjToJson<T>(string path, List<T> data)
        {
            // using System.Text.Json;
            var json = JsonSerializer.Serialize(data, typeof(List<T>),
                new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges
                        .All),
                    WriteIndented = true
                });

            WriteAllText(path, json);
        }


        private static void WriteAllText(string path, string data)
        {
            File.WriteAllText(path, data);
        }

        private static void CreateFile(string path)
        {
            var fileStream = File.Create(path);
            fileStream.Close();
        }

        private static bool Exists(string path)
        {
            return File.Exists(path);
        }

        /// Collection-larda olan deyiskliklerin yeniden json-a yazilmasi
        public void SaveChanges<T>(List<T> data)
        {
            if (!data.Any()) return;
            var fileName = data.GetType().GetGenericArguments()[0].Name + ".json";
            SerializeObjToJson(fileName, data);
        }

    }
}



