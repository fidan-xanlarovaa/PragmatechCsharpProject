using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Week6_Task1
{
   
    public class Product
    {

        private string _categoryy;
        private string _list;
        private string _kiloo;
        private string _pricee;
        private string _shippingg;
        private string _date;
        public string categoryy 
        {
            get 
            {
                return _categoryy;
            }
            set 
            {
                if (value == null)
                {
                    MessageBox.Show("Zehmet olmasa deyer daxil edin.");
                }
                else
                {
                    _categoryy = value;
                }
            } 
        }
        public string list
        {
            get
            {
                return _list;
            }
            set
            {
                if (value == null)
                {
                    MessageBox.Show("Zehmet olmasa deyer daxil edin.");
                }
                else
                {
                    _list = value;
                }
            }
        }

        public string kiloo
        {
            get
            {
                return _kiloo;
            }
            set
            {
                if (value == "0")
                {
                    MessageBox.Show("Zehmet olmasa deyer daxil edin.");
                }
                else
                {
                    _kiloo = value;
                }
            }
        }

        public string pricee
        {
            get
            {
                return _pricee;
            }
            set
            {
                if (value == "0")
                {
                    MessageBox.Show("Zehmet olmasa deyer daxil edin.");
                }
                else
                {
                    _pricee = value;
                }
            }
        }

        public string shippingg
        {
            get
            {
                return _shippingg;
            }
            set
            {
                if (value == null)
                {
                    MessageBox.Show("Zehmet olmasa deyer daxil edin.");
                }
                else
                {
                    _shippingg = value;
                }
            }
        }

        public string date
        {
            get
            {
                return _date;
            }
            set
            {
                if (value == null)
                {
                    MessageBox.Show("Zehmet olmasa deyer daxil edin.");
                }
                else
                {
                    _date = value;
                }
            }
        }

        public string colourr { get; set; }
        
    }
    
    
}
