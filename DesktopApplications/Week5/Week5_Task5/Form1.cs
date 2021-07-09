using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string surname = textBox2.Text.Trim();
            string phoneNum = maskedTextBox1.Text;
            string birthDate = dateTimePicker1.Text;

            ListViewItem item = new ListViewItem();
            item.Text = name;
            item.SubItems.Add(surname);
            item.SubItems.Add(phoneNum);
            item.SubItems.Add(birthDate);
            listView1.Items.Add(item);



            //foreach (var items in Controls)
            //{
            //    if (items is TextBox txt)
            //    {
            //        TextBox tb = txt;
            //        if (tb.Name == "txtName" || tb.Name == "txtSurname" || tb.Name == "txtAge")  controllari temizlemek ucun bir variant
            //        {
            //            tb.Clear();
            //        }
            //       }
            //}

            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            textBox1.Focus();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
