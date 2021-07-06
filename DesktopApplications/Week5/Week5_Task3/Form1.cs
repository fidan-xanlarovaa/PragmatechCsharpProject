using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string strr = textBox2.Text.Trim().ToLower();
            if (listBox1.Items.Contains(strr))
            {
                MessageBox.Show($"The ListBox contains the element {textBox2.Text}");
            }

            else
            {
                MessageBox.Show($"The ListBox doesn't contains the element {textBox2.Text}");
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string str=textBox1.Text.Trim().ToLower();
            listBox1.Items.Add(str);
            MessageBox.Show("Element succesfully Added");
            textBox1.Clear();
            textBox1.Focus();
            

        }

        private void Count_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Number of elemnts in listBox is " + listBox1.Items.Count.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
