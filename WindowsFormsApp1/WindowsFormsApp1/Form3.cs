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
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string youtubeBx = YoutubeIDtxtBx.Text;
            string LinkBx = YoutubeLinkTxtBx.Text;
            string DescriptionBx = DescriptiontxtBx.Text;
            int deleteOrNot = 0;
            char notuseable = '|';

            if (string.IsNullOrEmpty(youtubeBx) || string.IsNullOrEmpty(LinkBx) || string.IsNullOrEmpty(DescriptionBx))
            {
                MessageBox.Show("Fill all parts");
            }
            else if (youtubeBx.Contains(notuseable) || LinkBx.Contains(notuseable) || DescriptionBx.Contains(notuseable))
            {
                MessageBox.Show("Dont use this char: |");
            }
            else
            {
                string filePath = @"C:\Users\Monster\OneDrive\Masaüstü\Hak\WindowsFormsApp1\WindowsFormsApp1\video1.csv";
                string line = $"{DescriptionBx}|{youtubeBx}|{LinkBx}|{deleteOrNot}";

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(line);
                    }
                    MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}