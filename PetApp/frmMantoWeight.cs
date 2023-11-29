using System;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmMantoWeight : Form
    {
        public frmMantoWeight()
        {
            InitializeComponent();
        }

        private void frmMantoWeight_Load(object sender, EventArgs e)
        {
            CargarRegistrosDePeso();
        }

        private void CargarRegistrosDePeso()
        {
            using (var db = new PetDBContext())
            {
                dgvdatapeso.DataSource = db.Pesos.ToList();
            }
        }

        private void btnnewregistro_Click(object sender, EventArgs e)
        {
            //llamamos al formulario de edicion y nuevo registro
            var frmnewWeight = new frmNewWeight(0);
            frmnewWeight.ShowDialog();
            // Actualiza la lista después de agregar el registro
            CargarRegistrosDePeso();
        }

        private void btndeleteregistro_Click(object sender, EventArgs e)
        {
            if (dgvdatapeso.SelectedRows.Count > 0)
            {
                int idPesoSeleccionado = (int)dgvdatapeso.SelectedRows[0].Cells["Id"].Value;


                //Muestra un mensaje de confirmación antes de eliminar
                DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (var db = new PetDBContext())
                    {
                        var peso = db.Pesos.FirstOrDefault(p => p.Id == idPesoSeleccionado);

                        if (peso != null)
                        {
                            try
                            {
                                db.Pesos.Remove(peso);
                                db.SaveChanges();
                                CargarRegistrosDePeso(); // Actualiza la lista después de eliminar
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al eliminar el registro de peso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {      
                MessageBox.Show("Debe seleccionar un registro de peso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneditarregistro_Click(object sender, EventArgs e)
        {
            if (dgvdatapeso.SelectedRows.Count > 0)
            {
                int idPesoSeleccionado = (int)dgvdatapeso.SelectedRows[0].Cells["Id"].Value;

                // Abre un formulario para editar el registro de peso
                var frmEditWeight = new frmEditWeight(idPesoSeleccionado);
                frmEditWeight.ShowDialog();

                // Actualiza la lista después de editar
                CargarRegistrosDePeso();
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un registro de peso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
