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

namespace assignment_files_otherfuction_of_reading_delete
{
    public partial class Form1 : Form
    {
        string filePath = "courses.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    File.WriteAllLines(filePath, new string[] { "Computer Science", "Java Programming", "C# Development", "Networking" });
                }

                string[] lines = File.ReadAllLines(filePath);
                listBox1.Items.Clear();

                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }

                MessageBox.Show("Faylka si guul leh ayaa loo akhriyay iyadoo la adeegsanayo File.ReadAllLines!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad ayaa dhacay: " + ex.Message);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    List<string> linesList = new List<string>(File.ReadAllLines(filePath));

                    if (linesList.Count > 0)
                    {
                        string removedItem = linesList[0];
                        linesList.RemoveAt(0);

                        File.WriteAllLines(filePath, linesList);

                        listBox1.Items.Clear();
                        foreach (string item in linesList)
                        {
                            listBox1.Items.Add(item);
                        }

                        MessageBox.Show("Waxaa la tirtiray shaygii: " + removedItem);
                    }
                    else
                    {
                        MessageBox.Show("Faylku waa madhan yahay, wax looga tirtiro ma jiraan.");
                    }
                }
                else
                {
                    MessageBox.Show("Faylka lama helin. Marka hore akhri faylka.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad ayaa dhacay: " + ex.Message);
            }
        }
    }
}