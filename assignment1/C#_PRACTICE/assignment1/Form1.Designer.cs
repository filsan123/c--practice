namespace assignment1
{
    partial class assignment1
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
            this.studentname = new System.Windows.Forms.Label();
            this.studentid = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.lbloutbut = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentname
            // 
            this.studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.Location = new System.Drawing.Point(115, 107);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(248, 23);
            this.studentname.TabIndex = 0;
            this.studentname.Text = "Enter the student name";
            this.studentname.Click += new System.EventHandler(this.lbname_Click);
            // 
            // studentid
            // 
            this.studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentid.Location = new System.Drawing.Point(107, 141);
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(204, 23);
            this.studentid.TabIndex = 1;
            this.studentid.Text = "Enter the studen id";
            // 
            // department
            // 
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(102, 183);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(218, 23);
            this.department.TabIndex = 2;
            this.department.Text = "Enter the department";
            // 
            // semester
            // 
            this.semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.Location = new System.Drawing.Point(96, 218);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(224, 23);
            this.semester.TabIndex = 3;
            this.semester.Text = " Enter the semester";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(443, 100);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(258, 30);
            this.txtname.TabIndex = 4;
            this.txtname.Text = "FATHI";
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtstudentid
            // 
            this.txtstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.Location = new System.Drawing.Point(443, 141);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(258, 30);
            this.txtstudentid.TabIndex = 5;
            this.txtstudentid.Text = "3455566";
            this.txtstudentid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdepartment
            // 
            this.txtdepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(443, 181);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(258, 30);
            this.txtdepartment.TabIndex = 6;
            this.txtdepartment.Text = "SETGGH";
            this.txtdepartment.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtsemester
            // 
            this.txtsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsemester.Location = new System.Drawing.Point(443, 225);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(258, 30);
            this.txtsemester.TabIndex = 7;
            this.txtsemester.Text = "5";
            // 
            // lbloutbut
            // 
            this.lbloutbut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutbut.Location = new System.Drawing.Point(90, 291);
            this.lbloutbut.Name = "lbloutbut";
            this.lbloutbut.Size = new System.Drawing.Size(639, 45);
            this.lbloutbut.TabIndex = 8;
            this.lbloutbut.Click += new System.EventHandler(this.lboutput_Click);
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.BackColor = System.Drawing.Color.LightGray;
            this.btnshowinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowinfo.Location = new System.Drawing.Point(90, 376);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(169, 34);
            this.btnshowinfo.TabIndex = 9;
            this.btnshowinfo.Text = "show info";
            this.btnshowinfo.UseVisualStyleBackColor = false;
            this.btnshowinfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.LightGray;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(307, 373);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(148, 37);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightGray;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(503, 373);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(141, 37);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(112, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 51);
            this.label1.TabIndex = 12;
            this.label1.Text = "STUDENT INFORMATION";
            // 
            // assignment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lbloutbut);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.department);
            this.Controls.Add(this.studentid);
            this.Controls.Add(this.studentname);
            this.Name = "assignment1";
            this.Text = "student information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentname;
        private System.Windows.Forms.Label studentid;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label lbloutbut;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
    }
}

