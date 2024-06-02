using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace hotel_managmenet_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconn obj = new myconn();
           
            obj.con.Open();
            obj.qry = "SELECT * FROM users WHERE username = '" + textUserName.Text + "' AND password = '" + textPassword.Text + "'";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.dr = obj.cmd.ExecuteReader();
         
            if (obj.dr.Read())
            {
                obj.con.Close();
                MessageBox.Show("Successfully logged in");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide(); /// hide the login desing
            }
            else
            {
                obj.con.Close();
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
