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
