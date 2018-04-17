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
                SqlCommand comando = new SqlCommand(string.Format(" insert into asignatura (clave, asignatura, ht, hp, cr, prerequisito) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    pget.clave, pget.telefono, pget.identidad, pget.direccion, pget.tipo_visita, pget.departamento, pget.descripcion, pget.fecha), conn);

                retorno = comando.ExecuteNonQuery();

            }
            return retorno;
        }
    }
}