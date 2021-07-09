using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string carBrand = brand.Text.Trim().ToLower();
            switch (carBrand)
            {
                case "bmw":
                    modell.Items.Add("303");
                    modell.Items.Add("326");
                    modell.Items.Add("321");
                    modell.Items.Add("335");
                    modell.Items.Add("320");
                    break;
                case "hyundai":
                    modell.Items.Add("accent");
                    modell.Items.Add("i20");
                    modell.Items.Add("i30");
                    modell.Items.Add("i10");
                    modell.Items.Add("santro");
                    break;
                case "ford":
                    modell.Items.Add("fiesta");
                    modell.Items.Add("ka");
                    modell.Items.Add("focus");
                    modell.Items.Add("figo");
                    break;
                case "bugatti":
                    modell.Items.Add("veyron");
                    modell.Items.Add("chiron");
                    modell.Items.Add("divo");
                    modell.Items.Add("centodieci");
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string carBrand = brand.Text.Trim().ToLower();
            string carModell = modell.Text.Trim().ToLower();
            string carMotor= motor.Text.Trim().ToLower();
            string carFuel= fuel.Text.Trim().ToLower();
            string carBody=body.Text.Trim().ToLower();
            string carSpeed=speed.Text.Trim().ToLower();
            string year = dateTimePicker1.Text;
            ListViewItem car = new ListViewItem();
            car.Text = carBrand;
            car.SubItems.Add(carModell);
            car.SubItems.Add(carMotor);
            car.SubItems.Add(carFuel);
            car.SubItems.Add(carBody);
            car.SubItems.Add(carSpeed);
            car.SubItems.Add(year);
            car.UseItemStyleForSubItems = false; 
            car.SubItems.Add(string.Empty).BackColor = button2.BackColor;
            listView1.Items.Add(car);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (colorDialog1 = new ColorDialog())
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    button2.BackColor = colorDialog1.Color;
                }
            }
        }
    }
}
