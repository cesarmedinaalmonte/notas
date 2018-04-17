using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace notas
{
    public class datosbasedt
    {
        public static int agregar(datosget pget)
        {
            int retorno = 0;
            using (SqlConnection conn = conexion1.octenerconexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(" insert into asignatura (clave, asignatura, ht, hp, cr) values ('{0}','{1}','{2}','{3}','{4})",
                    pget.clave, pget.asignatura , pget.ht, pget.hp, pget.cr), conn);

              
            }
            return retorno;

        }


        public static int agregar1(datosget pget)
        {
            int retorno = 0;
            using (SqlConnection conn = conexion1.octenerconexion())
            {
                
                SqlCommand comando = new SqlCommand(string.Format(" insert into profesor (nombre, correo, telefono) values ('{0}','{1}','{2}')",
                    pget.nombre, pget.correo, pget.telefono), conn);
                retorno = comando.ExecuteNonQuery();

            }
            return retorno;

        }
    }
}