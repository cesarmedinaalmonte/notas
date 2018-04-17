using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas
{
    public class datosget
    {
        public int idasignatura { get; set; }
        public string clave { get; set; }
        public string asignatura { get; set; }
        public string ht { get; set; }
        public string hp { get; set; }
        public string cr { get; set; }
        
        // tabla de profesor
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }


        public datosget() { }


        public datosget(int pidasignatura, string pclave, string pasignatura, String pht, string php, string pcr, string pnombre, string pcorreo,string ptelefono )
        { 
            this.idasignatura = pidasignatura;
            this.clave = pclave;
            this.asignatura = pasignatura;
            this.ht = pht;
            this.hp = php;
            this.cr = pcr;
         
            // tabla de profesor
            this.nombre = pnombre;
            this.correo = pcorreo;
            this.telefono = ptelefono;


        }


    }

}
