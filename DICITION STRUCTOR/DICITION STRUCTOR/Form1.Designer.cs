namespace DICITION_STRUCTOR
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
            this.lbltestscore1 = new System.Windows.Forms.Label();
            this.lbltestscore2 = new System.Windows.Forms.Label();
            this.lbltestscore3 = new System.Windows.Forms.Label();
            this.lblaverag = new System.Windows.Forms.Label();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.txtscore4 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtcalculate1 = new System.Windows.Forms.TextBox();
            this.txtcalculate2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltestscore1
            // 
            this.lbltestscore1.AutoSize = true;
            this.lbltestscore1.Location = new System.Drawing.Point(68, 43);
            this.lbltestscore1.Name = "lbltestscore1";
            this.lbltestscore1.Size = new System.Drawing.Size(105, 20);
            this.lbltestscore1.TabIndex = 0;
            this.lbltestscore1.Text = "Test score #1";
            // 
            // lbltestscore2
            // 
            this.lbltestscore2.AutoSize = true;
            this.lbltestscore2.Location = new System.Drawing.Point(68, 75);
            this.lbltestscore2.Name = "lbltestscore2";
            this.lbltestscore2.Size = new System.Drawing.Size(105, 20);
            this.lbltestscore2.TabIndex = 1;
            this.lbltestscore2.Text = "Test score #2";
            this.lbltestscore2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbltestscore3
            // 
            this.lbltestscore3.AutoSize = true;
            this.lbltestscore3.Location = new System.Drawing.Point(72, 106);
            this.lbltestscore3.Name = "lbltestscore3";
            this.lbltestscore3.Size = new System.Drawing.Size(101, 20);
            this.lbltestscore3.TabIndex = 2;
            this.lbltestscore3.Text = "test score #3";
            // 
            // lblaverag
            // 
            this.lblaverag.AutoSize = true;
            this.lblaverag.Location = new System.Drawing.Point(117, 154);
            this.lblaverag.Name = "lblaverag";
            this.lblaverag.Size = new System.Drawing.Size(68, 20);
            this.lblaverag.TabIndex = 3;
            this.lblaverag.Text = "Average";
            this.lblaverag.Click += new System.EventHandler(this.lbltestscore4_Click);
            // 
            // txtscore1
            // 
            this.txtscore1.Location = new System.Drawing.Point(382, 37);
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(100, 26);
            this.txtscore1.TabIndex = 4;
            // 
            // txtscore2
            // 
            this.txtscore2.Location = new System.Drawing.Point(382, 71);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(100, 26);
            this.txtscore2.TabIndex = 5;
            // 
            // txtscore3
            // 
            this.txtscore3.Location = new System.Drawing.Point(382, 106);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(100, 26);
            this.txtscore3.TabIndex = 6;
            // 
            // txtscore4
            // 
            this.txtscore4.Location = new System.Drawing.Point(403, 165);
            this.txtscore4.Name = "txtscore4";
            this.txtscore4.Size = new System.Drawing.Size(100, 26);
            this.txtscore4.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(182, 313);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(164, 64);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "calculate  average";
            this.btncalculate.UseVisualStyleBackColor = true;
            // 
            // txtcalculate1
            // 
            this.txtcalculate1.Location = new System.Drawing.Point(419, 303);
            this.txtcalculate1.Name = "txtcalculate1";
            this.txtcalculate1.Size = new System.Drawing.Size(174, 26);
            this.txtcalculate1.TabIndex = 9;
            this.txtcalculate1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcalculate2
            // 
            this.txtcalculate2.Location = new System.Drawing.Point(419, 351);
            this.txtcalculate2.Name = "txtcalculate2";
            this.txtcalculate2.Size = new System.Drawing.Size(174, 26);
            this.txtcalculate2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltestscore2);
            this.groupBox1.Controls.Add(this.lbltestscore1);
            this.groupBox1.Controls.Add(this.lbltestscore3);
            this.groupBox1.Controls.Add(this.lblaverag);
            this.groupBox1.Controls.Add(this.txtscore4);
            this.groupBox1.Controls.Add(this.txtscore1);
            this.groupBox1.Controls.Add(this.txtscore2);
            this.groupBox1.Controls.Add(this.txtscore3);
            this.groupBox1.Location = new System.Drawing.Point(37, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 246);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ente three test score ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtcalculate2);
            this.Controls.Add(this.txtcalculate1);
            this.Controls.Add(this.btncalculate);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Test score Average";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltestscore1;
        private System.Windows.Forms.Label lbltestscore2;
        private System.Windows.Forms.Label lbltestscore3;
        private System.Windows.Forms.Label lblaverag;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.TextBox txtscore4;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtcalculate1;
        private System.Windows.Forms.TextBox txtcalculate2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

