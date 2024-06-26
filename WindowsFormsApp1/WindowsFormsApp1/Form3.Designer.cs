namespace WindowsFormsApp1
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.YoutubeIDtxtBx = new System.Windows.Forms.TextBox();
            this.DescriptiontxtBx = new System.Windows.Forms.TextBox();
            this.YoutubeLinkTxtBx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 40);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(474, 12);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(56, 19);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.18F);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Video";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(195, 178);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(56, 20);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Youtube ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Youtube Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Video Description";
            // 
            // YoutubeIDtxtBx
            // 
            this.YoutubeIDtxtBx.Location = new System.Drawing.Point(123, 32);
            this.YoutubeIDtxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YoutubeIDtxtBx.Name = "YoutubeIDtxtBx";
            this.YoutubeIDtxtBx.Size = new System.Drawing.Size(250, 20);
            this.YoutubeIDtxtBx.TabIndex = 5;
            // 
            // DescriptiontxtBx
            // 
            this.DescriptiontxtBx.Location = new System.Drawing.Point(123, 97);
            this.DescriptiontxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptiontxtBx.Name = "DescriptiontxtBx";
            this.DescriptiontxtBx.Size = new System.Drawing.Size(250, 20);
            this.DescriptiontxtBx.TabIndex = 6;
            // 
            // YoutubeLinkTxtBx
            // 
            this.YoutubeLinkTxtBx.Location = new System.Drawing.Point(123, 63);
            this.YoutubeLinkTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YoutubeLinkTxtBx.Name = "YoutubeLinkTxtBx";
            this.YoutubeLinkTxtBx.Size = new System.Drawing.Size(250, 20);
            this.YoutubeLinkTxtBx.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.YoutubeLinkTxtBx);
            this.panel2.Controls.Add(this.DescriptiontxtBx);
            this.panel2.Controls.Add(this.YoutubeIDtxtBx);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Location = new System.Drawing.Point(52, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 210);
            this.panel2.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YoutubeIDtxtBx;
        private System.Windows.Forms.TextBox DescriptiontxtBx;
        private System.Windows.Forms.TextBox YoutubeLinkTxtBx;
        private System.Windows.Forms.Panel panel2;
    }
}