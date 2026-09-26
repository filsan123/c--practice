namespace asignment_form1
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
            this.month = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtmonthtext = new System.Windows.Forms.TextBox();
            this.txtdayofmonth = new System.Windows.Forms.TextBox();
            this.txtyeartext = new System.Windows.Forms.TextBox();
            this.dateoutputlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the day of the week";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Location = new System.Drawing.Point(158, 84);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(219, 20);
            this.month.TabIndex = 1;
            this.month.Text = "Enter the name of mounth";
            this.month.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the numaric  of the mounth";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter the year";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayoftheweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayoftheweek.Location = new System.Drawing.Point(489, 36);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(100, 26);
            this.txtdayoftheweek.TabIndex = 4;
            this.txtdayoftheweek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmonthtext
            // 
            this.txtmonthtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmonthtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonthtext.Location = new System.Drawing.Point(489, 81);
            this.txtmonthtext.Name = "txtmonthtext";
            this.txtmonthtext.Size = new System.Drawing.Size(100, 26);
            this.txtmonthtext.TabIndex = 5;
            this.txtmonthtext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdayofmonth
            // 
            this.txtdayofmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofmonth.Location = new System.Drawing.Point(489, 145);
            this.txtdayofmonth.Name = "txtdayofmonth";
            this.txtdayofmonth.Size = new System.Drawing.Size(100, 26);
            this.txtdayofmonth.TabIndex = 6;
            this.txtdayofmonth.TextChanged += new System.EventHandler(this.txtdayofmonth_TextChanged);
            // 
            // txtyeartext
            // 
            this.txtyeartext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyeartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyeartext.Location = new System.Drawing.Point(489, 196);
            this.txtyeartext.Name = "txtyeartext";
            this.txtyeartext.Size = new System.Drawing.Size(100, 26);
            this.txtyeartext.TabIndex = 7;
            // 
            // dateoutputlabel
            // 
            this.dateoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateoutputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateoutputlabel.Location = new System.Drawing.Point(121, 274);
            this.dateoutputlabel.Name = "dateoutputlabel";
            this.dateoutputlabel.Size = new System.Drawing.Size(534, 66);
            this.dateoutputlabel.TabIndex = 8;
            this.dateoutputlabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(514, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(334, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateoutputlabel);
            this.Controls.Add(this.txtyeartext);
            this.Controls.Add(this.txtdayofmonth);
            this.Controls.Add(this.txtmonthtext);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "asignment one";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtmonthtext;
        private System.Windows.Forms.TextBox txtdayofmonth;
        private System.Windows.Forms.TextBox txtyeartext;
        private System.Windows.Forms.Label dateoutputlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

