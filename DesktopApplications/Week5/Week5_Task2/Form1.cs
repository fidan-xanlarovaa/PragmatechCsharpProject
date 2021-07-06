using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim().ToLower();
            listBox1.Items.Add(str);
            MessageBox.Show("Element succesfully Added");
            textBox1.Clear();
            textBox1.Focus();

        }
    }
}
