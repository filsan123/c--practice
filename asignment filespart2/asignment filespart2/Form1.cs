using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asignment_filespart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private const string FILE_NAME = "custom_data.txt";
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtInput.Text))
                {
                    StreamWriter outputFile = File.AppendText(FILE_NAME);
                    outputFile.WriteLine(txtInput.Text);
                    outputFile.Close();

                    MessageBox.Show("Xogta si guul leh ayaa loo qoray!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInput.Clear();
                    txtInput.Focus();
                }
                else
                {
                    MessageBox.Show("Fadlan geli qoraal sanduuqa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad ayaa dhacay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                lstOutput.Items.Clear();

                if (File.Exists(FILE_NAME))
                {
                    StreamReader inputFile = File.OpenText(FILE_NAME);

                    while (!inputFile.EndOfStream)
                    {
                        string line = inputFile.ReadLine();
                        lstOutput.Items.Add(line);
                    }

                    inputFile.Close();
                }
                else
                {
                    MessageBox.Show("Faylku ma jiro ama weli lama abuurin!", "Notice",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad ayaa dhacay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstOutput.SelectedIndex != -1)
                {
                    lstOutput.Items.RemoveAt(lstOutput.SelectedIndex);

                    StreamWriter outputFile = File.CreateText(FILE_NAME);
                    foreach (var item in lstOutput.Items)
                    {
                        outputFile.WriteLine(item.ToString());
                    }
                    outputFile.Close();

                    MessageBox.Show("Xubintii la doortay waa la tirtiray!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fadlan dooro xubin ka tirsan Liiska si aad u tirtirto.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad ayaa dhacay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(FILE_NAME))
                {
                    DialogResult dialogResult = MessageBox.Show("Ma hubtaa inaad rabto inaad tirtirto faylka oo dhan?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(FILE_NAME);
                        lstOutput.Items.Clear();
                        MessageBox.Show("Faylka si buuxda ayaa loo tirtiray!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Faylku ma jiro ama horay ayaa loo tirtiray.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad ayaa dhacay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
