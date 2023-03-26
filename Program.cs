using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace newDBMS
{
    internal static class Program
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

            String connString = @"Data Source=DESKTOP-MQAIVDL\SQLEXPRESS;Initial Catalog=DBMS;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                Console.WriteLine("Succesful connection!");
                conn.Close();
            }
        }
    }
}
