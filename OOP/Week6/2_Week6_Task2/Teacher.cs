using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week6_Task2
{/*
            *  Muellim modeli yaradin, id, adi,soyadi,vezifesi,dogum tarixi, ise baslama tarixi, islediyi yer
            *  datalarini saxlasin.
            *  Id: sadece oxuna biler auto yaradilacaq.
            *  Vezife: daxil edilmeyibse null-dursa Teacher deye set edilsin.
            *  Ise Baslama tarixi : Muellimin eger 23 yasi varsa muellim olaraq fealiyyet gostere biler.
            */
    class Teacher
    {
        Random rnd = new Random();
        public Teacher()
        {
            _id=rnd.Next(1,10000);
             
        }
        private int _id;


        public int Id
        {
            get { return _id; }
            
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private string _position;

        public string Position
        {
            get { return _position; }
            set
            {
                if (value==null || value=="" || value == " ")
                {
                    _position = "Teacher";

                }
                else
                {
                    _position = value;
                }
            }
        }

        private DateTime _birthDay;

        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }

        private DateTime _data;

        public DateTime Date
        {
            get { return _data; }
            set { _data = value; }
        }

        private string _schoolNumber;

        public string SchoolNumber
        {
            get { return _schoolNumber; }
            set { _schoolNumber = value; }
        }
        public void ShowDate()
        {
            Console.WriteLine("--------------------------------------------------------------\n");
            Console.WriteLine($"Id: {_id}\nAdi: {_name}\nSoyadi: {_surname}\nVezifesi: {_position}\n" +
                $"Dogum Tarixi: {_birthDay}\nIse daxil olma Tarixi: {_data}\nIslediyi mekteb:{_schoolNumber}\n");
            Console.WriteLine("--------------------------------------------------------------\n");

        }
        public void CanWork()
        {
            if (_data.Year - _birthDay.Year>23)
            {
                Console.WriteLine("Siz muellim kimi fealiyyet gostere bilrsiniz");
            }
            else
            {
                Console.WriteLine("Siz muellim kimi fealiyyet gostere Bilmersiniz");

            }

        }





    }
}
