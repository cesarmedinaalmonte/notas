using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class profesor : Form
    {
        public profesor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnguardarp_Click(object sender, EventArgs e)
        {
            datosget datosget = new datosget();


            datosget.nombre = txtnombrep.Text;
            datosget.correo = txtemailp.Text;
            datosget.telefono = txttelp.Text;
           



            int resultado = datosbasedt.agregar1(datosget);


            if (resultado > 0)
            {

                MessageBox.Show("Datos de Seccion Guardados Correctamente", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(" No se Pudieron Guardar Datos de Seccion  ", "Error al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Form formp = new inicio();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }
    }
}
