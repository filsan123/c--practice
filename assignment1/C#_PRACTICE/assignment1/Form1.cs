using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class assignment1 : Form
    {
        public assignment1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Samaynta varibles-ka
            string studentname, department, fulloutput;
            int studentid, semester;

            // Ka soo qaadashada Textbox-yada
            studentname = txtname.Text;
            studentid = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = int.Parse(txtsemester.Text);

            // Isku xirka (Concatenation)
            fulloutput = studentname + ", " + studentid + ", " + department + ", " + semester;

            // Muujinta Output-ka
            lbloutbut.Text = fulloutput;
        }

        private void lboutput_Click(object sender, EventArgs e)
        { 
        }

        private void textBox2_TextChanged(object sender, EventArgs  e)
        {
         

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void lbname_Click(object sender, EventArgs e)
        {
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutbut.Text = "";
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
