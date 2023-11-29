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
    public partial class frmMantoMascotas : Form
    {
        public frmMantoMascotas()
        {
            InitializeComponent();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (gpbedit.Visible == true)
            {
                gpbedit.Visible = false;
                btneditar.Text = "Editar";
                
            }
            else
            {
                gpbedit.Visible = true;
                btneditar.Text = "Cancelar";
                btnClose.Visible = false;
            }
            txtAlias.Text = dgvdata.SelectedRows[0].Cells["Alias"].Value.ToString();
            txtespecie.Text = dgvdata.SelectedRows[0].Cells["Especie"].Value.ToString();
            txtRaza.Text = dgvdata.SelectedRows[0].Cells["Raza"].Value.ToString();
            txtColor.Text = dgvdata.SelectedRows[0].Cells["ColorPelo"].Value.ToString();
            // Obtener la fecha de la celda correspondiente en la fila seleccionada
            if (DateTime.TryParse(dgvdata.SelectedRows[0].Cells["FechaNacimiento"].Value.ToString(), out DateTime fecha))
            {
                // Asignar la fecha al DateTimePicker
                dtFechaNacimiento.Value = fecha;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (var db = new PetDBContext())
            {
                // Verificamos si hay al menos una fila seleccionada
                if (dgvdata.SelectedRows.Count > 0)
                {
                    // Obtenemos el ID de la mascota seleccionada
                    int idMascotaSeleccionada = (int)dgvdata.SelectedRows[0].Cells["IdMascota"].Value;

                    // Buscamos la mascota en la base de datos por su ID
                    var mascota = db.Mascota.FirstOrDefault(m => m.IdMascota == idMascotaSeleccionada);

                    if (mascota != null)
                    {
                        // Actualizamos los datos de la mascota con los valores de los controles de edición
                        mascota.Alias = txtAlias.Text;
                        mascota.Especie = txtespecie.Text;
                        mascota.Raza = txtRaza.Text;
                        mascota.ColorPelo = txtColor.Text;
                        mascota.FechaNacimiento = dtFechaNacimiento.Value;

                        // Guardamos los cambios en la base de datos
                        db.SaveChanges();

                        // Actualizamos el DataGridView para reflejar los cambios
                        dgvdata.DataSource = db.Mascota.ToList();

                        // Limpiamos los controles de edición
                        LimpiarControlesEdicion();

                        // Ocultamos el panel de edición y restauramos el botón "Editar"
                        gpbedit.Visible = false;
                        btneditar.Text = "Editar";
                        btnClose.Visible = true;
                    
                    }
                }
            }
        }

        private void LimpiarControlesEdicion()
        {
            txtAlias.Text = string.Empty;
            txtespecie.Text = string.Empty;
            txtRaza.Text = string.Empty;
            txtColor.Text = string.Empty;
            dtFechaNacimiento.Value = DateTime.Now;
        }

        private void frmMantoMascotas_Load(object sender, EventArgs e)
        {
            using (var db = new PetDBContext())
            {
                dgvdata.DataSource = db.Mascota.ToList();
            }
        }

       
        private void btneliminarr_Click(object sender, EventArgs e)
        {

            if (dgvdata.SelectedRows.Count > 0)
            {
                // Obtén el ID de la mascota seleccionada
                int idMascotaSeleccionada = (int)dgvdata.SelectedRows[0].Cells["IdMascota"].Value;

                // Muestra un cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta mascota?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (var db = new PetDBContext())
                    {
                        // Busca la mascota en la base de datos por su ID
                        var mascota = db.Mascota.FirstOrDefault(m => m.IdMascota == idMascotaSeleccionada);

                        if (mascota != null)
                        {
                            // Elimina la mascota de la base de datos
                            db.Mascota.Remove(mascota);
                            db.SaveChanges();

                            // Actualiza el DataGridView para reflejar los cambios
                            dgvdata.DataSource = db.Mascota.ToList();
                        }
                        //ocultar panel
                        gpbedit.Visible = false;
                        btneditar.Text = "Editar";
                        btnClose.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una mascota para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelarr_Click(object sender, EventArgs e)
        {
            gpbedit.Visible = false;
            btneditar.Text = "Editar";
            btnClose.Visible = true;
        }
    }
}
