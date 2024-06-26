/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form

    {
        public static Form2 Instance;
        public System.Windows.Forms.ListView lw1;



        public Form2()
        {
            int deleteOrNot = 0;

            InitializeComponent();
            Instance = this;
            lw1 = listView1;
        }

        System.Windows.Forms.Timer tmr = null;
        private void startTimer()
        {
            tmr = new Timer();
            tmr.Interval = 10000;
            tmr.Tick += new EventHandler(timer1_Tick);
            tmr.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {



            label2.Text = listView1.Columns.Count.ToString() + " video updated";
            startTimer();
          

            string[] lines = File.ReadAllLines(@"C:\Users\Monster\OneDrive\Masaüstü\Hak\WindowsFormsApp1\WindowsFormsApp1\video1.csv");

            foreach (string line in lines)
            {
                string[] columns = line.Split('|');
                ListViewItem lvi = new ListViewItem(columns[0]);
                for (int i = 1; i < columns.Count(); i++)
                {
                    lvi.SubItems.Add(columns[i]);
                }
                listView1.Items.Add(lvi);

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = "last update date is " + DateTime.Now.ToString("yyyy.MM.dd.HH:mm:ss");
            listView1.Refresh();
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.Items[i];

                if (item.SubItems.Count > 3 && item.SubItems[3].Text == "1")
                {
                    listView1.Items.RemoveAt(i);
                }
            }











        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string selectedVideoText = selectedItem.SubItems[0].Text;
                label3.Text = selectedVideoText;
                // PictureBox.Load($"https://img.youtube.com/vi/{selectedItem.Text}/default.jpg");
            }




        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
           
            string zeroOrOne = listView1.SelectedItems[0].SubItems[3].Text;

            if (zeroOrOne == "0")
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                selectedItem.SubItems[3].Text = "1";

            }
        }

        private void ThumbnailBox_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();

            ListViewItem selectedItem = listView1.SelectedItems[0];
            MessageBox.Show(selectedItem.ToString());
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string url = listView1.SelectedItems[0].SubItems[2].Text;
                System.Diagnostics.Process.Start(url);
            }
        }
    }
}*/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public System.Windows.Forms.ListView lw1;

        public Form2()
        {
            int deleteOrNot = 0;

            InitializeComponent();
            Instance = this;
            lw1 = listView1;
        }

        System.Windows.Forms.Timer tmr = null;
        private void startTimer()
        {
            tmr = new Timer();
            tmr.Interval = 10000;
            tmr.Tick += new EventHandler(timer1_Tick);
            tmr.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Monster\OneDrive\Masaüstü\Hak\WindowsFormsApp1\WindowsFormsApp1\video1.csv");

            foreach (string line in lines)
            {
                string[] columns = line.Split('|');
                ListViewItem lvi = new ListViewItem(columns[0]);
                for (int i = 1; i < columns.Count(); i++)
                {
                    lvi.SubItems.Add(columns[i]);
                }
                listView1.Items.Add(lvi);
            }

            if (listView1.Items.Count == 0)
            {
                label2.Text = "There is no video";
            }
            else
            {
                label2.Text = listView1.Items.Count.ToString() + " video updated";
            }

            startTimer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = "last update date is " + DateTime.Now.ToString("yyyy.MM.dd.HH:mm:ss");
            listView1.Refresh();
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.Items[i];

                if (item.SubItems.Count > 3 && item.SubItems[3].Text == "1")
                {
                    listView1.Items.RemoveAt(i);
                }
            }

            if (listView1.Items.Count == 0)
            {
                label2.Text = "There is no video";
            }
            else
            {
                label2.Text = listView1.Items.Count.ToString() + " video updated";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string selectedVideoText = selectedItem.SubItems[0].Text;
                label3.Text = selectedVideoText;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string zeroOrOne = listView1.SelectedItems[0].SubItems[3].Text;

            if (zeroOrOne == "0")
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[3].Text = "1";
            }
        }

        private void ThumbnailBox_Click(object sender, EventArgs e)
        {
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();

            ListViewItem selectedItem = listView1.SelectedItems[0];
            MessageBox.Show(selectedItem.ToString());
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string url = listView1.SelectedItems[0].SubItems[2].Text;
                System.Diagnostics.Process.Start(url);
            }
        }
    }
}
