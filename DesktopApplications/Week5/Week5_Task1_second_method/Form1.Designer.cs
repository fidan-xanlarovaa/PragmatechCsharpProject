
namespace Week5_Task1_second_method
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SecondInteger = new System.Windows.Forms.Label();
            this.Operations = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.FirstInteger = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(263, 49);
            this.numericUpDown1.MaximumSize = new System.Drawing.Size(1000000, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(281, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(263, 90);
            this.numericUpDown2.MaximumSize = new System.Drawing.Size(1000000, 0);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(281, 20);
            this.numericUpDown2.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "%",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(263, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(129, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 27;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondInteger
            // 
            this.SecondInteger.AutoSize = true;
            this.SecondInteger.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondInteger.ForeColor = System.Drawing.Color.Red;
            this.SecondInteger.Location = new System.Drawing.Point(125, 90);
            this.SecondInteger.Name = "SecondInteger";
            this.SecondInteger.Size = new System.Drawing.Size(132, 22);
            this.SecondInteger.TabIndex = 23;
            this.SecondInteger.Text = "Second integer";
            // 
            // Operations
            // 
            this.Operations.AutoSize = true;
            this.Operations.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operations.ForeColor = System.Drawing.Color.Red;
            this.Operations.Location = new System.Drawing.Point(148, 137);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(100, 22);
            this.Operations.TabIndex = 24;
            this.Operations.Text = "Operations";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(325, 217);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 22);
            this.result.TabIndex = 25;
            // 
            // FirstInteger
            // 
            this.FirstInteger.AutoSize = true;
            this.FirstInteger.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstInteger.ForeColor = System.Drawing.Color.Red;
            this.FirstInteger.Location = new System.Drawing.Point(148, 49);
            this.FirstInteger.Name = "FirstInteger";
            this.FirstInteger.Size = new System.Drawing.Size(109, 22);
            this.FirstInteger.TabIndex = 22;
            this.FirstInteger.Text = "First integer";
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1.ForeColor = System.Drawing.Color.Red;
            this.result1.Location = new System.Drawing.Point(277, 230);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(60, 22);
            this.result1.TabIndex = 26;
            this.result1.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.SecondInteger);
            this.Controls.Add(this.FirstInteger);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SecondInteger;
        private System.Windows.Forms.Label Operations;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label FirstInteger;
        private System.Windows.Forms.Label result1;
    }
}

