using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_managmenet_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void registerCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form3 frm3 = new Form3();
            frm3.Show();
            this.Close();/// hide 2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();


        }
    }
}
