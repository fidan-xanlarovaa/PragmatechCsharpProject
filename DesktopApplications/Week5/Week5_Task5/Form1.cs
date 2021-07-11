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
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            textBox1.Focus();
        }

        
    }
}
