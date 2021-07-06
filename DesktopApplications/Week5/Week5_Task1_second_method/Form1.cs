using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Task1_second_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // birinci metod ile ferqi ondan ibarerdir ki, burda duymeye click etdikde, digerinde ise istenilen value deyisdikde emeliyyat yerine yetirilir
        private void button1_Click(object sender, EventArgs e)
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
