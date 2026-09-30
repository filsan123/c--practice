using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Akhrinta xogta gelinta ee magacyada macalinka
            string customerName = txtcostumer.Text;
            double previousReading = Convert.ToDouble(txtprevious.Text);
            double currentReading = Convert.ToDouble(txtcurrent.Text);
            double unitPrice = Convert.ToDouble(txtunitprice.Text);

            // 2. Xisaabinta Units-ka
            double usageUnits = currentReading - previousReading;

            // 3. Xisaabinta Subtotal iyo Tax (7%)
            double subtotal = usageUnits * unitPrice;
            double taxAmount = subtotal * 0.07;

            // 4. Xisaabinta Total Bill ($5 Fixed charge ku jiraa)
            double totalBill = subtotal + taxAmount + 5;

            // 5. Ku soo bandhigida TextBox-yada hoose iyo astaanta $
            txtElectricityUsage.Text = usageUnits.ToString();
            txtTaxAmount.Text = "$" + taxAmount.ToString("0.00");
            txtTotalBill.Text = "$" + totalBill.ToString("0.00");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}