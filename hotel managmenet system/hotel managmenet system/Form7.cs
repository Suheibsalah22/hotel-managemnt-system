using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace hotel_managmenet_system
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picturebox_hotel.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "INSERT INTO  hotel__rooms(room_number, room_type, room_floor, room_price, room_description, room_img, created_date) VALUES (@room_number, @room_type, @room_floor, @room_price, @room_description, @room_img, GETDATE())";

            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@room_number", txtRoomNum.Text);
            obj.cmd.Parameters.AddWithValue("@room_type", room_type.Text);
            obj.cmd.Parameters.AddWithValue("@room_floor", room_floor.Text);
            obj.cmd.Parameters.AddWithValue("@room_price", room_price.Text);
            obj.cmd.Parameters.AddWithValue("@room_description", room_descrip.Text);
            // Convert image to byte array
            byte[] imgData;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                picturebox_hotel.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imgData = ms.ToArray();
            }
            obj.cmd.Parameters.AddWithValue("@room_img", imgData);
            try
            {
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Room created successfully.");
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                obj.con.Close();
            }
        }
        void displayData()
        {
            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "select * from hotel__rooms order by room_id";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.dr = obj.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(obj.dr);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            obj.con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayData();
        }
        private void DeleteRoom(int roomId)
        {
            // Implement the deletion logic here, using the roomId to identify the room to delete
            // Example:
            // string deleteQuery = "DELETE FROM hotel__rooms WHERE room_id = @roomId";
            // using (SqlConnection connection = new SqlConnection(connectionString))
            // {
            //     using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            //     {
            //         command.Parameters.AddWithValue("@roomId", roomId);
            //         connection.Open();
            //         command.ExecuteNonQuery();
            //     }
            // }

            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "delete from hotel__rooms where room_id = @room_id";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@room_id", roomId);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("waa la tiray!");
            displayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["deleteColumn"].Index) // Check if delete button is clicked
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow != null && selectedRow.Cells["room_id"].Value != null)
                {
                    int roomId = Convert.ToInt32(selectedRow.Cells["room_id"].Value);
                    DeleteRoom(roomId);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            myconn obj = new myconn();
            obj.con.Open();
            obj.qry = "update hotel__rooms set room_number = @room_number, room_type = @room_type, room_floor = @room_floor, room_price = @room_price, room_description = @room_description, room_img = @room_img, created_date = GETDATE() where room_id = @room_id";

            obj.cmd = new SqlCommand(obj.qry, obj.con);

            obj.cmd.Parameters.AddWithValue("@room_number", txtRoomNum.Text);
            obj.cmd.Parameters.AddWithValue("@room_type", room_type.Text);
            obj.cmd.Parameters.AddWithValue("@room_floor", room_floor.Text);
            obj.cmd.Parameters.AddWithValue("@room_price", room_price.Text);
            obj.cmd.Parameters.AddWithValue("@room_description", room_descrip.Text);

            // Convert image to byte array
            byte[] imgData;
            using (MemoryStream ms = new MemoryStream())
            {
                picturebox_hotel.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imgData = ms.ToArray();
            }
            obj.cmd.Parameters.AddWithValue("@room_img", imgData);

            obj.cmd.Parameters.AddWithValue("@room_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());

            try
            {
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Room updated successfully.");
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                obj.con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["room_id"].Value);
                DeleteRoom(roomId);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }


}
