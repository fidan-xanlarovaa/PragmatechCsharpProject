

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Task1
{
    class Pizza
    {
        private decimal _qiymeti;
        public string adi { get; set; }

        public string olcusu { get; set; }
        public string pizzanin_kenari { get; set; }
        public decimal qiymeti
        {
            get

            {
                return _qiymeti;
            }
            set
            {
                if (qiymeti > 0)
                {
                    value = _qiymeti;
                }
            }

        }

        public static Pizza addPizzaOrder(string a, string b, string c)
        {
            Pizza piz = new Pizza();
            piz.adi = a;
            piz.pizzanin_kenari = b;
            piz.olcusu = c;

            return piz;
        }

        public void CalculatePrice()
        {


            if (olcusu == "kicik")
            {
                _qiymeti = 1m;
            }

            else if (olcusu == "orta")
            {
                _qiymeti = 1.25m;
            }

            else if (olcusu == "boyuk")
            {
                _qiymeti = 1.75m;
            }

            else if (olcusu == "maxi")
            {
                _qiymeti = 2m;
            }


            if (pizzanin_kenari == "qalin")
            {
                _qiymeti = _qiymeti + 2m;
            }
        }


        public void addPizzaOrderList(ListView a)
        {
            if (adi!="" && pizzanin_kenari!="" && olcusu!="") {
                ListViewItem pizza1 = new ListViewItem();
                pizza1.Text = adi;
                pizza1.SubItems.Add(olcusu);
                pizza1.SubItems.Add(pizzanin_kenari);
                pizza1.SubItems.Add(qiymeti.ToString());
                a.Items.Add(pizza1);
            }

            else
            {
                MessageBox.Show("Xahis olunur butun xanalari doldurasiniz");
            }
        }

        public static decimal TotalPrice(ListView listView1)
        {
            decimal total = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                decimal a = System.Convert.ToDecimal(listView1.Items[i].SubItems[3].Text);
                total = a + total;
            }

            return total;
        }

        public static void Remove(ListView listView1)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listView1.SelectedItems[i].Remove();          
            }
        }
        

    }
}





