using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int c = 0;
            int b = Convert.ToInt32(numericUpDown2.Value);
            string ch = comboBox1.Text;

            switch (ch)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
                case "%":
                    c = a % b;
                    break;

                default:
                    break;
            }



            result1.Text = c.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int c = 0;
            int b = Convert.ToInt32(numericUpDown2.Value);
            string ch = comboBox1.Text;

            switch (ch)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
                case "%":
                    c = a % b;
                    break;

                default:
                    break;
            }



            result1.Text = c.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int c = 0;
            int b = Convert.ToInt32(numericUpDown2.Value);
            string ch = comboBox1.Text;

            switch (ch)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
                case "%":
                    c = a % b;
                    break;

                default:
                    break;
            }



            result1.Text = c.ToString();
        }
    }
}
