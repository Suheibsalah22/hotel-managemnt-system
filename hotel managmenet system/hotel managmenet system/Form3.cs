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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "INSERT INTO customers_info (customer_name, customer_phone, customer_address, customer_status,numer_of_people,type_room,createdDate) VALUES (@Name, @phone, @address, @status,@people,@typeroom,GETDATE())";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@Name", textName.Text);
            obj.cmd.Parameters.AddWithValue("@phone", textPhone.Text);
            obj.cmd.Parameters.AddWithValue("@address", textAdress.Text);
            obj.cmd.Parameters.AddWithValue("@status", status.Text);
            obj.cmd.Parameters.AddWithValue("@people", textPeople.Text);
            obj.cmd.Parameters.AddWithValue("@typeroom", typeRoom.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("waa la diiwan galiyey customerkan.");
           displayData();

        }
        void displayData()
        {
            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "select * from customers_info order by custom_id";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.dr = obj.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(obj.dr);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            obj.con.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                textCustomerId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                textName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
             
                textPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textAdress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                status.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textPeople.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                typeRoom.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "update customers_info set customer_name = @Name, customer_phone = @phone, customer_address = @address, customer_status = @status, numer_of_people = @people, type_room = @typeroom, createdDate = GETDATE() where custom_id = @customer_id";

            obj.cmd = new SqlCommand(obj.qry, obj.con);
           

            obj.cmd.Parameters.AddWithValue("@Name", textName.Text);
            obj.cmd.Parameters.AddWithValue("@phone", textPhone.Text);
            obj.cmd.Parameters.AddWithValue("@address", textAdress.Text);
            obj.cmd.Parameters.AddWithValue("@status", status.Text);
            obj.cmd.Parameters.AddWithValue("@people", textPeople.Text);
            obj.cmd.Parameters.AddWithValue("@typeroom", typeRoom.Text);
            obj.cmd.Parameters.AddWithValue("@customer_id", textCustomerId.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("waa la update-gareey xogta.");

            displayData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "select case when max(custom_id) is null then 1 else max(custom_id)+1 end from customers_info";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            int x = System.Convert.ToInt32(obj.cmd.ExecuteScalar());
            textCustomerId.Text = x.ToString();

            obj.con.Close();
            textName.Focus();
        
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            displayData();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///
            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "delete from customers_info where custom_id = @customer_id";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@customer_id", textCustomerId.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("waa la tiray!");
            displayData();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
