using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionBD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionPersona frmGestion = new FrmGestionPersona();
             frmGestion.MdiParent=this;
            frmGestion.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaPersona frmConsulta = new FrmConsultaPersona();
           frmConsulta.MdiParent=this;
            frmConsulta.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
