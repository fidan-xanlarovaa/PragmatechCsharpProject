using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void order_Click(object sender, EventArgs e)
        {

            ArrayList AllorderedProducts=new ArrayList();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            Product product = new Product(category.Text.Trim().ToLower(), prList.Text.Trim().ToLower(), kilo.Text.Trim().ToLower(), price.Text.Trim().ToLower(), shipping.Text.Trim().ToLower(), dateTimePicker1.Text, string.Empty);
            AllorderedProducts.Add(product);
            ListViewItem product1 = new ListViewItem();

            product1.Text = product.categoryy;
            product1.SubItems.Add(product.list);
            product1.SubItems.Add(product.kiloo);
            product1.SubItems.Add(product.pricee);
            product1.SubItems.Add(product.shippingg);
            product1.SubItems.Add(product.date);
            product1.UseItemStyleForSubItems = false;
            product1.SubItems.Add(product.colourr).BackColor=colour.BackColor;
            listView1.Items.Add(product1);

        }

        private void remove_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count-1; i >=0; i--)
            {
                listView1.SelectedItems[i].Remove();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim().ToLower();
            bool k = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
            if (listView1.Items[i].Text==str)
                {
                    MessageBox.Show("var");

                    k = true;
                    break;
                }
            else if(k==false)
                {
                    MessageBox.Show("yoxdu");
                    break;
                }
                    
                
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
