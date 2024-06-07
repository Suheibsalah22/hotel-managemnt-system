namespace hotel_managmenet_system
{
    partial class Form7
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
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.room_floor = new System.Windows.Forms.TextBox();
            this.room_price = new System.Windows.Forms.TextBox();
            this.room_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.room_descrip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picturebox_hotel = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(183, 90);
            this.txtRoomNum.Multiline = true;
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(253, 67);
            this.txtRoomNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room number";
            // 
            // room_floor
            // 
            this.room_floor.Location = new System.Drawing.Point(183, 223);
            this.room_floor.Multiline = true;
            this.room_floor.Name = "room_floor";
            this.room_floor.Size = new System.Drawing.Size(253, 67);
            this.room_floor.TabIndex = 2;
            this.room_floor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // room_price
            // 
            this.room_price.Location = new System.Drawing.Point(665, 223);
            this.room_price.Multiline = true;
            this.room_price.Name = "room_price";
            this.room_price.Size = new System.Drawing.Size(261, 67);
            this.room_price.TabIndex = 3;
            // 
            // room_type
            // 
            this.room_type.Location = new System.Drawing.Point(665, 90);
            this.room_type.Multiline = true;
            this.room_type.Name = "room_type";
            this.room_type.Size = new System.Drawing.Size(261, 67);
            this.room_type.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room Floor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room Price";
            // 
            // room_descrip
            // 
            this.room_descrip.Location = new System.Drawing.Point(209, 352);
            this.room_descrip.Multiline = true;
            this.room_descrip.Name = "room_descrip";
            this.room_descrip.Size = new System.Drawing.Size(253, 67);
            this.room_descrip.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Room Description";
            // 
            // picturebox_hotel
            // 
            this.picturebox_hotel.Location = new System.Drawing.Point(598, 320);
            this.picturebox_hotel.Name = "picturebox_hotel";
            this.picturebox_hotel.Size = new System.Drawing.Size(339, 232);
            this.picturebox_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_hotel.TabIndex = 10;
            this.picturebox_hotel.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 748);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 67);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(339, 58);
            this.button2.TabIndex = 12;
            this.button2.Text = "Browse Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(775, 748);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 67);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 748);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(315, 67);
            this.button4.TabIndex = 14;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1059, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(672, 159);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1059, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(315, 67);
            this.button5.TabIndex = 16;
            this.button5.Text = "Show All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(26, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 36);
            this.button6.TabIndex = 17;
            this.button6.Text = " Back Home";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1783, 847);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picturebox_hotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.room_descrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.room_type);
            this.Controls.Add(this.room_price);
            this.Controls.Add(this.room_floor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomNum);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox room_floor;
        private System.Windows.Forms.TextBox room_price;
        private System.Windows.Forms.TextBox room_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox room_descrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picturebox_hotel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}