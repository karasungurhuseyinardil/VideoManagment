using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Monster\OneDrive\Masaüstü\Hak\WindowsFormsApp1\WindowsFormsApp1\admin1.csv");
            bool isValidUser = false;

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                if (data[0] == UserNameTxtBx.Text && data[1] == PasswordTextBx.Text)
                {
                    isValidUser = true;
                    break;
                }
            }

            if (isValidUser)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
