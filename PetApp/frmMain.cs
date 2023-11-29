using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNewUser = new frmNewUser();
            frmNewUser.MdiParent = this;
            frmNewUser.Show();
        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNewPet = new frmNewPet();
            frmNewPet.MdiParent = this;
            frmNewPet.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMantoUsuarios = new frmMantoUsuarios();
            frmMantoUsuarios.MdiParent = this;
            frmMantoUsuarios.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var frmnewcustomer = new frmNewCustomer();  
            frmnewcustomer.MdiParent = this;
            frmnewcustomer.Show();
        }

        private void mascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMantoMascotas = new frmMantoMascotas();
            frmMantoMascotas.MdiParent = this;
            frmMantoMascotas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMantoCliente = new frmMantoCliente();
            frmMantoCliente.MdiParent = this;
            frmMantoCliente.Show();
        }

        private void registroDePesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNewWeight = new frmMantoWeight();
            frmNewWeight.MdiParent = this;
            frmNewWeight.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmmantovacuna = new frmMantoVacunas();
            frmmantovacuna.MdiParent = this;
            frmmantovacuna.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new AcercaDe();
            frmAbout.MdiParent = this;
            frmAbout.Show();
        }

        private void proximaVacunacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProximaVacunacion = new FrmProximaVacunacion();
            frmProximaVacunacion.MdiParent = this;
            frmProximaVacunacion.Show();
        }

        
    }
}
