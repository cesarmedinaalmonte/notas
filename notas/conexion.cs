using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace notas
{
    class conexion
    {
        private static SqlConnection conn = new SqlConnection("Data Source=CESAR-LAPTOP;Initial Catalog=;Integrated Security=True");

        public static SqlConnection octenerconexion()
        {
            if (conn == null)
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            return conn;
        }

        public static void opoencon()
        {
            if (conn == null)
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        public static void cerrarcon()
        {
            if (conn != null)
            {
                try
                {
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}

