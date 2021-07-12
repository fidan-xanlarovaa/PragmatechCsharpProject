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
        public string categoryy ;
        public string list;
        public string kiloo;
        public string pricee;
        public string shippingg;
        public string date;
        public string colourr;

       public  Product(string cat,string listt,string kilo,string price,string shipping,string datee, string colour)
        {
            categoryy=cat;
            list=listt;
            kiloo=kilo;
            pricee= price;
            shippingg= shipping;
            date= datee;
            colourr= colour;
    }

        
    }
}
