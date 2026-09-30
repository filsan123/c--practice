namespace Electricity_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcostumer = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtElectricityUsage = new System.Windows.Forms.TextBox();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(311, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the costumer name     :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcostumer
            // 
            this.txtcostumer.Location = new System.Drawing.Point(787, 49);
            this.txtcostumer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcostumer.Name = "txtcostumer";
            this.txtcostumer.Size = new System.Drawing.Size(122, 28);
            this.txtcostumer.TabIndex = 1;
            this.txtcostumer.Text = "ali";
            this.txtcostumer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(787, 101);
            this.txtprevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(122, 28);
            this.txtprevious.TabIndex = 2;
            this.txtprevious.Text = "1200";
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(787, 155);
            this.txtcurrent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(122, 28);
            this.txtcurrent.TabIndex = 3;
            this.txtcurrent.Text = "1360";
            this.txtcurrent.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(787, 216);
            this.txtunitprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(122, 28);
            this.txtunitprice.TabIndex = 4;
            this.txtunitprice.Text = "0.25";
            this.txtunitprice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(311, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter previous Reading       :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(311, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter current reading         :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(311, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter price per unit ($)      :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(126, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(997, 135);
            this.label5.TabIndex = 8;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Electicity Usage (units)                           :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tax amount (7%)                                    :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(382, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Bill ( including $5 Fixed charge)     :";
            // 
            // txtElectricityUsage
            // 
            this.txtElectricityUsage.Location = new System.Drawing.Point(674, 359);
            this.txtElectricityUsage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtElectricityUsage.Name = "txtElectricityUsage";
            this.txtElectricityUsage.Size = new System.Drawing.Size(241, 28);
            this.txtElectricityUsage.TabIndex = 12;
            this.txtElectricityUsage.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(674, 403);
            this.txtTaxAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(241, 28);
            this.txtTaxAmount.TabIndex = 13;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(674, 438);
            this.txtTotalBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(241, 28);
            this.txtTotalBill.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Khaki;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(473, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "Electricity Bill Calculator";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(536, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 60);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate Bill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.txtTaxAmount);
            this.Controls.Add(this.txtElectricityUsage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.txtcostumer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcostumer;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtElectricityUsage;
        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

