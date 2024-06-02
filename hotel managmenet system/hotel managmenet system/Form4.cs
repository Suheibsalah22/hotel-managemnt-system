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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "select count(*) from customers_info";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            int x = System.Convert.ToInt32(obj.cmd.ExecuteScalar());
            textDashboard.Text = x.ToString();

            obj.con.Close();
          
        }
    }
}
