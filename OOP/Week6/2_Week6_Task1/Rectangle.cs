using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week6_Task1
{
    class Rectangle
    {
        public Rectangle(int u,int e)
        {
            Uzunluq = u;
            En = e;
        }
        private int _uzunluq;

        
        public int Uzunluq
        {
            get 
            { 
                return _uzunluq; 
            }
            set 
            {
                if (value > 0)
                {
                    _uzunluq = value;

                }
                else
                {
                    _uzunluq = 0;
                }
            }
        }

        private int _en;
        public int En {

            get
            {
                return _en;
            }

            set
            {
                if (value>0)
                {
                    _en = value;
                }
                else
                {
                    _en = 0;
                }
            
            } 
        }

        public int Sahe { get; set; }

        public int Calc()
        {
            Sahe = _en * _uzunluq;
            return Sahe;
        }

        #region Niye Saheni prop kimi yazanda duzgun islemedi?
        //private int _sahe;

        //public int Sahe
        //{
        //    get { return _sahe; }
        //    set 
        //    {
        //        value = _en * _uzunluq;
        //        _sahe = value; 
        //    }
        //}

    #endregion

}

}

