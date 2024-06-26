using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string youtubeBx = UpdateIDtxtBx.Text;
            string LinkBx = UpdateLinktxtBx.Text;
            string DescriptionBx = UpdateDescriptiontxtBx.Text;
            _ = Form2.Instance.listView1.SelectedItems[0].SubItems[1].Text = DescriptionBx;
            char notuseable = '|';


        }

        private void SaveUpdateButton_Click(object sender, EventArgs e)
        {
            string lines1 = Form2.Instance.listView1.SelectedItems[0].SubItems[1].Text;

            string youtubeBx = UpdateIDtxtBx.Text;
            string LinkBx = UpdateLinktxtBx.Text;
            string DescriptionBx = UpdateDescriptiontxtBx.Text;
            char notuseable = '|';
            int deleteOrNot = 0;

            if (string.IsNullOrEmpty(UpdateIDtxtBx.Text) || string.IsNullOrEmpty(UpdateLinktxtBx.Text) || string.IsNullOrEmpty(UpdateDescriptiontxtBx.Text))
            {
                MessageBox.Show("Fill all parts");
            }
            else if (UpdateIDtxtBx.Text.Contains(notuseable) || LinkBx.Contains(notuseable) || DescriptionBx.Contains(notuseable))
            {
                MessageBox.Show("Dont use this char: |");
            }
            else
            {
                string filePath = @"C:\Users\Monster\OneDrive\Masaüstü\Hak\WindowsFormsApp1\WindowsFormsApp1\video1.csv";
                string updatedLine = lines1;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}