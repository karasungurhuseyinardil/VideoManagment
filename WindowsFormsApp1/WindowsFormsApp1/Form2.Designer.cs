namespace WindowsFormsApp1

{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ThumbnailBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDateTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 38);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.18F);
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "There are 8 saved videos, 3 deleted videos ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 76);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(228, 263);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Video ID";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Uploader";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Link";
            this.columnHeader3.Width = 38;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İsDeleted";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDateTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.OpenButton);
            this.panel2.Controls.Add(this.ThumbnailBox);
            this.panel2.Location = new System.Drawing.Point(245, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 240);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(208, 190);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(56, 28);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(110, 190);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(68, 28);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 190);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(72, 28);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ThumbnailBox
            // 
            this.ThumbnailBox.Image = global::WindowsFormsApp1.Properties.Resources.images;
            this.ThumbnailBox.InitialImage = null;
            this.ThumbnailBox.Location = new System.Drawing.Point(12, 0);
            this.ThumbnailBox.Margin = new System.Windows.Forms.Padding(2);
            this.ThumbnailBox.Name = "ThumbnailBox";
            this.ThumbnailBox.Size = new System.Drawing.Size(316, 151);
            this.ThumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ThumbnailBox.TabIndex = 0;
            this.ThumbnailBox.TabStop = false;
            this.ThumbnailBox.Click += new System.EventHandler(this.ThumbnailBox_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(232, 162);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(211, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Last update will be shown after 10 seconds";
            this.labelDateTime.Click += new System.EventHandler(this.labelDateTime_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.PictureBox ThumbnailBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView listView1;
    }
}