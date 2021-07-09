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

        private void Add_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            listBox1.Items.Add(str.Trim().ToLower());
            textBox1.Clear();
            textBox1.Focus();

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count-1; i >=0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
            
        }

        private void Mix_Click(object sender, EventArgs e)
        {
            
            int count = listBox1.Items.Count;
            int numArrayElement1;
            if (count % 2 == 0)
            {
                numArrayElement1 = count/2;
            }
            else
            {
                numArrayElement1 = count / 2+1;
            }
            object[] evenIndexArray = new object[numArrayElement1];
            object[] oddIndexArray = new object[count/2];
            int k = 0;
            int z = 0;
            

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenIndexArray[k] = listBox1.Items[i];
                    k++;
                }

                else
                {
                    oddIndexArray[z] = listBox1.Items[i];
                    z++;

                }
            }

            k = numArrayElement1 - 1;
            z = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items[i] = oddIndexArray[z];
                    z++;
                }

                else
                {
                    listBox1.Items[i] = evenIndexArray[k];
                    k--;

                }

            }

        }
    }
}
