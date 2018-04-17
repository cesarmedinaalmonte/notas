using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitas2
{
    public class datosget
    {
        public int idasignatura { get; set; }
        public string clave { get; set; }
        public string asignatura { get; set; }
        public string ht { get; set; }
        public string hp { get; set; }
        public string cr { get; set; }
        public string prerequisito { get; set; }
       

        public datosget() { }


        public datosget(int pidasignatura, string pclave, string pasignatura, String pht, string php, string pcr,string pprerequisito)
        {
            this.idasignatura= pidasignatura;
            this.clave = pclave;
            this.asignatura = pasignatura;
            this.ht = pht;
            this.hp = php;
            this.cr = pcr;
            this.prerequisito = pprerequisito;
            

        }


    }

}
