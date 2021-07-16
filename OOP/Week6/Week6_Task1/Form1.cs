using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Week6_Task1
{
    public partial class Form1 : Form
    {
        List<Product> AllorderedProducts = new List<Product>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void order_Click(object sender, EventArgs e)
        {

            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            Product product = new Product
            {
                categoryy = category.Text.Trim().ToLower(),
                list=prList.Text.Trim().ToLower(),
                kiloo=kilo.Text.Trim().ToLower(),
                pricee=price.Text.Trim().ToLower(),
                shippingg=shipping.Text.Trim().ToLower(),
                date=dateTimePicker1.Text,
                colourr=string.Empty
            };
           
            AllorderedProducts.Add(product);
            
            ListViewItem product1 = new ListViewItem();
            product1.Text = product.categoryy;
            product1.SubItems.Add(product.list);
            product1.SubItems.Add(product.kiloo);
            product1.SubItems.Add(product.pricee);
            product1.SubItems.Add(product.shippingg);
            product1.SubItems.Add(product.date);
            product1.UseItemStyleForSubItems = false;
            product1.SubItems.Add(product.colourr).BackColor = colour.BackColor;
            listView1.Items.Add(product1);
            textBox2.Text = AllorderedProducts.Count.ToString();

        }

        private void remove_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = listView1.SelectedItems.Count-1; i >=0; i--)
            {
                listView1.SelectedItems[i].Remove();
                k++;
                
            }
           
            MessageBox.Show($"{k} eded mehsul ugurla silindi");
            textBox2.Text = listView1.Items.Count.ToString();


        }

        private void search_Click(object sender, EventArgs e)
        {

            int index=0;
            string str = textBox1.Text.Trim().ToLower();
            string str1= search_for.Text.Trim().ToLower();
           
            foreach (ColumnHeader header in listView1.Columns)
            {
                if (header.Text.Trim().ToLower() == str1)
                {
                    index = listView1.Columns.IndexOf(header);
                }
            }

            bool k = false;
            int count = 0;
            for (int i = 0; i < AllorderedProducts.Count; i++)
            {
                switch (index)
                {
                    case 0:
                        if (AllorderedProducts[i].categoryy == str)
                        {
                            count++;
                            k = true;
                        }
                        break;
                    case 1:
                        if (AllorderedProducts[i].list == str)
                        {
                            count++;
                            k = true;
                        }
                        break;
                    case 2:
                        if (AllorderedProducts[i].kiloo == str)
                        {
                            count++;
                            k = true;
                        }
                        break;
                    case 3:
                        if (AllorderedProducts[i].pricee == str)
                        {
                            count++;
                            k = true;
                        }
                        break;
                    case 4:
                        if (AllorderedProducts[i].shippingg == str)
                        {
                            count++;
                            k = true;
                        }
                        break;
                    case 5:
                        if (AllorderedProducts[i].date == str)
                        {
                            count++;
                            k = true;
                        }
                        break;
                    default:
                        break;
                }

                
            }
            
            if (k == false)
            {
                MessageBox.Show("Axtarishiniza uyun netice yoxdur");                
            }
            else
            {
                MessageBox.Show("Axtarishiniza uyun "+count+" netice tapildi");
            }
        }

        private void colour_Click(object sender, EventArgs e)
        {
            using (colorDialog1=new ColorDialog())
            {
                if (colorDialog1.ShowDialog()==DialogResult.OK)
                {
                    colour.BackColor = colorDialog1.Color;
                }
            } 

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryy = category.Text.Trim().ToLower();
            string[] dress = { "koynek", "salvar", "etek", "don" };
            string[] toy = { "top", "mashin", "robot", "dinozavr", "hulk" };
            string[] carePr = { "Uz yuma geli", "tonik", "nemlendirci krem", "Sac ucun sprey"};
            string[] schoolPr = { "defter", "chanta", "qelem", "rengli karandashlar", "pozan" };


            switch (categoryy)
            {
                case "geyim":
                    prList.Items.Clear();
                    prList.Items.AddRange(dress);
                    break;
                case "oyuncaq":
                    prList.Items.Clear();
                    prList.Items.AddRange(toy);
                    break;
                case "baxim mehsullari":
                    
                    prList.Items.Clear();
                    prList.Items.AddRange(carePr);
                    break;
                case "ofis ve mekteb levazimatlari":
                    prList.Items.Clear();
                    prList.Items.AddRange(schoolPr);
                    break;
                default:
                    break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
