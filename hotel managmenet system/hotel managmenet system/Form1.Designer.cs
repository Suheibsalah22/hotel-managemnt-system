﻿namespace hotel_managmenet_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(370, 437);
            this.textUserName.Multiline = true;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(443, 67);
            this.textUserName.TabIndex = 2;
            this.textUserName.Text = "ali";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(357, 713);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(456, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(370, 580);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(443, 67);
            this.textPassword.TabIndex = 5;
            this.textPassword.Text = "1234";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1162, 787);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label2;
    }
}

