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
    public partial class frmMantoCliente : Form
    {
        public frmMantoCliente()
        {
            InitializeComponent();
        }

        private void frmMantoCliente_Load(object sender, EventArgs e)
        {
            using( var db = new PetDBContext())
            {
                dgvdata.DataSource = db.Cliente.ToList();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (gpbeditarcliente.Visible == true)
            {
                gpbeditarcliente.Visible = false;
                btneditar.Text = "Editar";
                btnClose.Visible = true;

            }
            else
            {
                gpbeditarcliente.Visible = true;
                btneditar.Text = "Cancelar";
                btnClose.Visible = false;
            }
            txbnamecompleto.Text = dgvdata.SelectedRows[0].Cells["NombreCompleto"].Value.ToString();
            txbtelefono.Text = dgvdata.SelectedRows[0].Cells["Telefono"].Value.ToString();
            txbemail.Text = dgvdata.SelectedRows[0].Cells["Email"].Value.ToString();
        }

     
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                // Obtén el ID del cliente seleccionado
                int idClienteSeleccionado = (int)dgvdata.SelectedRows[0].Cells["IdCliente"].Value;

                using (var db = new PetDBContext())
                {
                    // Busca el cliente en la base de datos por su ID
                    var cliente = db.Cliente.FirstOrDefault(c => c.IdCliente == idClienteSeleccionado);

                    if (cliente != null)
                    {
                        // Actualiza los datos del cliente con los valores de los controles de edición
                        cliente.NombreCompleto = txbnamecompleto.Text;
                        cliente.Telefono = txbtelefono.Text;
                        cliente.Email = txbemail.Text;

                        // Guarda los cambios en la base de datos
                        db.SaveChanges();

                        // Actualiza el DataGridView para reflejar los cambios
                        dgvdata.DataSource = db.Cliente.ToList();

                        // Limpia los controles de edición
                        LimpiarControlesEdicion();

                        // Oculta el panel de edición y restaura el botón "Editar"
                        gpbeditarcliente.Visible = false;
                        btneditar.Text = "Editar";
                        btnClose.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                // Obtén el ID del cliente seleccionado
                int idClienteSeleccionado = (int)dgvdata.SelectedRows[0].Cells["IdCliente"].Value;

                // Muestra un cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (var db = new PetDBContext())
                    {
                        // Busca el cliente en la base de datos por su ID
                        var cliente = db.Cliente.FirstOrDefault(c => c.IdCliente == idClienteSeleccionado);

                        if (cliente != null)
                        {
                            // Elimina el cliente de la base de datos
                            db.Cliente.Remove(cliente);
                            db.SaveChanges();

                            // Actualiza el DataGridView para reflejar los cambios
                            dgvdata.DataSource = db.Cliente.ToList();

                            // Limpia los controles de edición
                            LimpiarControlesEdicion();

                            // Oculta el panel de edición
                            gpbeditarcliente.Visible = false;
                            btneditar.Text = "Editar";
                            btnClose.Visible = true;

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            gpbeditarcliente.Visible = false;
            btneditar.Text = "Editar";
            btnClose.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarControlesEdicion()
        {
            txbnamecompleto.Text = string.Empty;
            txbtelefono.Text = string.Empty;
            txbemail.Text = string.Empty;
        }
    }
}
