using System;
using System.Windows.Forms;

namespace asigment_calories_and_fat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Function-kan wuxuu xisaabinayaa Calories-ka iyo Percentage-ka Fat-ka
        private void CalculateFatPercentage()
        {
            // Hubi in labada TextBox ay leeyihiin lambarro sax ah
            if (double.TryParse(txtTotalCalories.Text, out double totalCalories) &&
                double.TryParse(txtFatGrams.Text, out double fatGrams))
            {
                if (totalCalories <= 0)
                {
                    MessageBox.Show("Total calories waa inuu ka weynaadaa 0!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xisaabi Calories ka yimid Fat-ka (1 gram of fat = 9 calories)
                double caloriesFromFat = fatGrams * 9;

                // Hubi in Calories ka yimid Fat uusan ka weynaan Total Calories
                if (caloriesFromFat > totalCalories)
                {
                    MessageBox.Show("Calories-ka ka yimid fat-ka kama weynaan karo Total Calories-ka dhabta ah!", "Logic Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xisaabi Boqolleyda (Percentage) Fat-ka
                double fatPercentage = (caloriesFromFat / totalCalories) * 100;

                // Ku muuji natiijada TextBox-yada hoose
                txtCaloriesFromFat.Text = caloriesFromFat.ToString("F2");
                txtFatPercentage.Text = $"{fatPercentage:F1}%";

                // Haddii CheckBox-ka Low Fat uu la checked-gareeyay
                if (chkLowFat.Checked)
                {
                    if (fatPercentage < 30)
                    {
                        MessageBox.Show("Cuntadan waa Low Fat (ka yar 30% fat)!", "Food Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cuntadan MA AHA Low Fat (Fat-keedu wuxuu ka badan yahay 30%)!", "Food Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fadlan geli lambar sax ah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // MARKA LA GUJIYO BUTTON-KA CALCULATE (Halkan ayaa qaladku ka jiray)
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateFatPercentage();
        }

        // Marka la gujiyo CheckBox-ka ama la calaamadeeyo
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateFatPercentage();
        }

        // BUTTON-KA CLEAR
        private void button1_Click(object sender, EventArgs e)
        {
            txtTotalCalories.Clear();
            txtFatGrams.Clear();
            txtCaloriesFromFat.Clear();
            txtFatPercentage.Clear();
            chkLowFat.Checked = false;
        }

        // BUTTON-KA EXIT
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtFatPercentage_TextChanged(object sender, EventArgs e)
        {
        }
    }
}