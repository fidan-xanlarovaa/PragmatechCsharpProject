using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Task1
{
    /*Bir Pizza Sifarish proqrami yaradilsin.Bunun ucun lazim olan detallar:
     * Pizzanin olculeri olsun : Kicik,Orta,Boyuk,Maxi Her secilmish olcuye gore pizzanin qiymetinin hesablanma indexi: 
     * Kicik=1, Orta=1.25, Boyuk=1.75, Maxi=2 Pizza adlari: Klassik,Qarishiq,Pendirli,Kolbasali,Italiano,Mexicano. Pizzanin kenarlari:
     * Qalin kenar,Ince kenar. Qalin kenar secilerse her pizza ucun qiymet xanasina 2 manat elave edilecekdir.
     
     
     
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            string n=name.Text.ToLower().Trim();
            string k = kenar.Text.ToLower().Trim();
            string o = size.Text.ToLower().Trim();

            Pizza piz=Pizza.addPizzaOrder(n, k, o);
            piz.CalculatePrice();
            piz.addPizzaOrderList(listView1);
            decimal sum=Pizza.TotalPrice(listView1);
            label15.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pizza.Remove(listView1);
            decimal sum = Pizza.TotalPrice(listView1);
            label15.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sifarisiniz ugurla tamamlandi. Kuryere odeyeceyiniz mebleg {label15.Text} manat teshkil edir. Bizi sechdiyiniz ucun tesekkur edirik:)");
            listView1.Items.Clear();
            decimal sum = Pizza.TotalPrice(listView1);
            label15.Text = sum.ToString();
        }

        
    }
}
