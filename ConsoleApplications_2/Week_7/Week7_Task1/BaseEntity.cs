using System;
using System.Collections;
using System.Text;

namespace Week7_Task1
{
    public class BaseEntity
    {
        public static readonly ArrayList _database; //readonly ile static constructor xaricinde basqa yerde Database=new Arraylist() yzilmasinin qarsisini aldiq.Yazsaq bele errror verer. readonly value typlarda olan const-un refernce typlarda qarsiliqidi

        static BaseEntity()
        {
            _database = new ArrayList();
        }
        static int idKeeper = 0;
        private int _id = idKeeper;

        public int Id
        {
            get { return _id; }
        }
        public BaseEntity()
        {
            _id = IdGenerator();
        }

        #region methods
        private int IdGenerator()
        {
            idKeeper++;
            return idKeeper;
        }
        #endregion
    }

}
