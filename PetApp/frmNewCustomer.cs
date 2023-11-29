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
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {   
            try
            {
                // Crear la instancia de la PetDBContext
                using (var db = new PetDBContext())
                {
                    // Crear el objeto Cliente
                    var nuevocliente = new Cliente()
                    {
                        // Asignar los valores que enviaremos 
                        NombreCompleto = txbnamecompleto.Text,
                        Telefono = txbtelefono.Text,
                        Email = txbemail.Text
                    };

                    // Guardar el cliente en la base de datos
                    db.Cliente.Add(nuevocliente);
                    db.SaveChanges();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Cliente creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar el formulario después de la creación exitosa
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier error
                MessageBox.Show("Error al crear el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
