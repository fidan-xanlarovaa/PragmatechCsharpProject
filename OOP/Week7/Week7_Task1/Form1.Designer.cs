
namespace Week7_Task1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kenar = new System.Windows.Forms.ComboBox();
            this.size = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PizzaninAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PizzaninKenari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PizzaninOlcusu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PizzaninQiymeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sebete elave et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name.FormattingEnabled = true;
            this.name.Items.AddRange(new object[] {
            "Klassik",
            "Qarishiq",
            "Pendirli",
            "Kolbasali",
            "Italiano",
            "Mexicano"});
            this.name.Location = new System.Drawing.Point(160, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 21);
            this.name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizzanin adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizzanin olchusu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pizzanin kenari";
            // 
            // kenar
            // 
            this.kenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kenar.FormattingEnabled = true;
            this.kenar.Items.AddRange(new object[] {
            "Ince",
            "Qalin"});
            this.kenar.Location = new System.Drawing.Point(160, 104);
            this.kenar.Name = "kenar";
            this.kenar.Size = new System.Drawing.Size(121, 21);
            this.kenar.TabIndex = 5;
            // 
            // size
            // 
            this.size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "Kicik",
            "Orta",
            "Boyuk",
            "Maxi"});
            this.size.Location = new System.Drawing.Point(160, 159);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(121, 21);
            this.size.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PizzaninAdi,
            this.PizzaninKenari,
            this.PizzaninOlcusu,
            this.PizzaninQiymeti});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(325, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 226);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PizzaninAdi
            // 
            this.PizzaninAdi.Text = "Pizzanin adi";
            this.PizzaninAdi.Width = 144;
            // 
            // PizzaninKenari
            // 
            this.PizzaninKenari.Text = "Pizzanin Kenari";
            this.PizzaninKenari.Width = 161;
            // 
            // PizzaninOlcusu
            // 
            this.PizzaninOlcusu.Text = "Pizzanin Olcusu";
            this.PizzaninOlcusu.Width = 151;
            // 
            // PizzaninQiymeti
            // 
            this.PizzaninQiymeti.Text = "Pizzanin Qiymeti";
            this.PizzaninQiymeti.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(11, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Qiymet cedveli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Olcuye gore:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(238, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kenarinin qainliqina gore:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kicik..........1 man";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Orta...........1.25 man";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Boyuk.........1.75 man";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "Maxi...........2 man";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(238, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Qalin..........2 man";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(238, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ince............0 man";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(725, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 24);
            this.label13.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(709, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "Umumi qiymet:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(837, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 24);
            this.label15.TabIndex = 19;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(894, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 24);
            this.label16.TabIndex = 20;
            this.label16.Text = "man";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(185, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "Sebetden sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(861, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 62);
            this.button3.TabIndex = 22;
            this.button3.Text = "Sifarish et";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 514);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.kenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kenar;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PizzaninAdi;
        private System.Windows.Forms.ColumnHeader PizzaninKenari;
        private System.Windows.Forms.ColumnHeader PizzaninOlcusu;
        private System.Windows.Forms.ColumnHeader PizzaninQiymeti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

