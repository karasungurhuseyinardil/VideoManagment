namespace WindowsFormsApp1
{
    partial class Form4
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateIDtxtBx = new System.Windows.Forms.TextBox();
            this.UpdateDescriptiontxtBx = new System.Windows.Forms.TextBox();
            this.UpdateLinktxtBx = new System.Windows.Forms.TextBox();
            this.SaveUpdateButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 50);
            this.panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(427, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "YoutubeID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "YoutubeLink";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // UpdateIDtxtBx
            // 
            this.UpdateIDtxtBx.Location = new System.Drawing.Point(122, 33);
            this.UpdateIDtxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateIDtxtBx.Name = "UpdateIDtxtBx";
            this.UpdateIDtxtBx.Size = new System.Drawing.Size(248, 20);
            this.UpdateIDtxtBx.TabIndex = 4;
            // 
            // UpdateDescriptiontxtBx
            // 
            this.UpdateDescriptiontxtBx.Location = new System.Drawing.Point(122, 91);
            this.UpdateDescriptiontxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateDescriptiontxtBx.Name = "UpdateDescriptiontxtBx";
            this.UpdateDescriptiontxtBx.Size = new System.Drawing.Size(248, 20);
            this.UpdateDescriptiontxtBx.TabIndex = 5;
            // 
            // UpdateLinktxtBx
            // 
            this.UpdateLinktxtBx.Location = new System.Drawing.Point(122, 63);
            this.UpdateLinktxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateLinktxtBx.Name = "UpdateLinktxtBx";
            this.UpdateLinktxtBx.Size = new System.Drawing.Size(248, 20);
            this.UpdateLinktxtBx.TabIndex = 6;
            // 
            // SaveUpdateButton
            // 
            this.SaveUpdateButton.Location = new System.Drawing.Point(176, 136);
            this.SaveUpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveUpdateButton.Name = "SaveUpdateButton";
            this.SaveUpdateButton.Size = new System.Drawing.Size(91, 49);
            this.SaveUpdateButton.TabIndex = 7;
            this.SaveUpdateButton.Text = "Save";
            this.SaveUpdateButton.UseVisualStyleBackColor = true;
            this.SaveUpdateButton.Click += new System.EventHandler(this.SaveUpdateButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveUpdateButton);
            this.panel2.Controls.Add(this.UpdateLinktxtBx);
            this.panel2.Controls.Add(this.UpdateDescriptiontxtBx);
            this.panel2.Controls.Add(this.UpdateIDtxtBx);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(24, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 253);
            this.panel2.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            this.Click += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UpdateIDtxtBx;
        private System.Windows.Forms.TextBox UpdateDescriptiontxtBx;
        private System.Windows.Forms.TextBox UpdateLinktxtBx;
        private System.Windows.Forms.Button SaveUpdateButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelButton;
    }
}