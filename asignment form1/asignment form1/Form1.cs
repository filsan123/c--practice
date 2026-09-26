using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asignment_form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //CREATING VARIABLES TO STORE INPUT DATA
            string dayoftheweek, dayofmonth, month, year, showdata;
            //VARIBLE TO STOR
            dayoftheweek = txtdayoftheweek.Text;
            month = txtmonthtext.Text;
            dayofmonth = txtdayofmonth.Text;
            year = txtyeartext.Text;
//PROCESSING CONCATINATIONS
            showdata = dayoftheweek + " " + month + " " + dayofmonth + " " + year;
//OUTPUTLABLE
            dateoutputlabel.Text = showdata;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
//CLEARING
            txtdayoftheweek.Clear();
            txtmonthtext.Clear();
            txtdayofmonth.Clear();
            txtyeartext.Clear();
            dateoutputlabel.Text = " ";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
//EXIT 
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtdayofmonth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
