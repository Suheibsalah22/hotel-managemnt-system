using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel_managmenet_system
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class myconn
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M516JTQ\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataReader dr;
        public string qry;
    }
}
