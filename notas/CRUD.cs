using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace notas
{
    class CRUD
    {   //Cadena de conexion a la base de dato
        private static SqlConnection Conn = new SqlConnection("Data Source=CESAR-LAPTOP\\SQLEXPRESS;Initial Catalog=pensum;Integrated Security=True");
        // Este metodo se utiliza para hacer las consulta a la base de datos sin resultado, es decir para ingresar,actualizar,borrar datos.
        public bool ConsultaSinResultado(string sql)
        {
            try
            {
                Conn.Open();
                SqlCommand comando = new SqlCommand(sql, Conn);
                comando.ExecuteNonQuery();
            }
            catch(SqlException ex )
            {
                MessageBox.Show(ex.ToString());
                return false;// esto son los retornos de falso si no se ejecuta  correctamente la sentencia SQL
            }
            finally 
            {
                Conn.Close();
            }
            return true;// Si todo se ejecuto correctamente el metodo retorna un valor verdadero.
        }
        public DataTable ConsultaConResultado(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                Conn.Open();
                SqlCommand cmd;// variable de tipo SqlCommand para contener la sentencia sql
                cmd = Conn.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd);
                da.Fill(dt); //se llena la variable DataTable con los la informacion de la variable data adapter 
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
            return dt;// retorna la variable con los datos de la table organizados.


        }
    }
}
