
namespace Week5_Task6
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
            this.brand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.motor = new System.Windows.Forms.ComboBox();
            this.fuel = new System.Windows.Forms.ComboBox();
            this.speed = new System.Windows.Forms.ComboBox();
            this.body = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CarBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Motorrr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.modell = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brand
            // 
            this.brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brand.FormattingEnabled = true;
            this.brand.Items.AddRange(new object[] {
            "BMW",
            "Hyundai",
            "Bugatti",
            "Ford"});
            this.brand.Location = new System.Drawing.Point(111, 28);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(121, 21);
            this.brand.TabIndex = 0;
            this.brand.SelectedIndexChanged += new System.EventHandler(this.brand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Brend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(250, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fuel type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(818, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(799, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Colour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(483, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Car body style";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(547, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 36);
            this.label7.TabIndex = 7;
            this.label7.Text = "Speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(272, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 36);
            this.label8.TabIndex = 8;
            this.label8.Text = "Motor";
            // 
            // motor
            // 
            this.motor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motor.FormattingEnabled = true;
            this.motor.Items.AddRange(new object[] {
            "Motor1",
            "Motor2",
            "Motor3",
            "Motor4",
            "Motor5",
            "Motor6"});
            this.motor.Location = new System.Drawing.Point(341, 28);
            this.motor.Name = "motor";
            this.motor.Size = new System.Drawing.Size(121, 21);
            this.motor.TabIndex = 9;
            // 
            // fuel
            // 
            this.fuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuel.FormattingEnabled = true;
            this.fuel.Items.AddRange(new object[] {
            "Fuel1",
            "Fuel2",
            "Fuel3",
            "Fuel4",
            "Fuel5",
            "Fuel6"});
            this.fuel.Location = new System.Drawing.Point(341, 75);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(121, 21);
            this.fuel.TabIndex = 11;
            // 
            // speed
            // 
            this.speed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speed.FormattingEnabled = true;
            this.speed.Items.AddRange(new object[] {
            "Speed1",
            "Speed2",
            "Speed3",
            "Speed4",
            "Speed5",
            "Speed6",
            "Speed7"});
            this.speed.Location = new System.Drawing.Point(613, 28);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(121, 21);
            this.speed.TabIndex = 12;
            // 
            // body
            // 
            this.body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.body.FormattingEnabled = true;
            this.body.Items.AddRange(new object[] {
            "Body1",
            "Body2",
            "Body3",
            "Body4",
            "Body5",
            "Body6"});
            this.body.Location = new System.Drawing.Point(613, 75);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(121, 21);
            this.body.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(883, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CarBrand,
            this.Model,
            this.Motorrr,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(111, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(972, 285);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CarBrand
            // 
            this.CarBrand.Text = "CarBrand";
            this.CarBrand.Width = 110;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 130;
            // 
            // Motorrr
            // 
            this.Motorrr.Text = "Motor";
            this.Motorrr.Width = 112;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FuelType";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Speed";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CarBodyStyle";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Colour";
            this.columnHeader5.Width = 110;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(1146, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modell
            // 
            this.modell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modell.FormattingEnabled = true;
            this.modell.Location = new System.Drawing.Point(111, 75);
            this.modell.Name = "modell";
            this.modell.Size = new System.Drawing.Size(121, 21);
            this.modell.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(883, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 29);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.modell);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.body);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.fuel);
            this.Controls.Add(this.motor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox motor;
        private System.Windows.Forms.ComboBox fuel;
        private System.Windows.Forms.ComboBox speed;
        private System.Windows.Forms.ComboBox body;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CarBrand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Motorrr;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox modell;
        private System.Windows.Forms.Button button2;
    }
}

