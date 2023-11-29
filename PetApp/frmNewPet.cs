using System;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmNewPet : Form
    {
        public frmNewPet()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new PetDBContext())
            {
                if (comboBox1.SelectedItem != null)
                {
                    // Obtenemos el ID del cliente seleccionado
                    int idClienteSeleccionado = (int)comboBox1.SelectedValue;

                    var nuevamascota = new Mascota()
                    {
                        IdCliente = idClienteSeleccionado,
                        Alias = txtAlias.Text,
                        Especie = txtespecie.Text,
                        Raza = txtRaza.Text,
                        ColorPelo = txtColor.Text,
                        FechaNacimiento = dtFechaNacimiento.Value
                    };

                    //Guardamos los cambios
                    db.Mascota.Add(nuevamascota);
                    db.SaveChanges();

                    // Crear la relación entre el cliente y la mascota
                    var relacionClienteMascota = new ClientesxMascotas()
                    {
                        IdCliente = idClienteSeleccionado,
                        IdMascota = nuevamascota.IdMascota // Usamos el Id de la mascot recién creada
                    };

                    // Agregar la relación al contexto y guardarla
                    db.ClientesxMascotas.Add(relacionClienteMascota);
                    db.SaveChanges();

                    MessageBox.Show("Mascota guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cerramos el formulario después de guardar
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente antes de guardar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmNewPet_Load(object sender, EventArgs e)
        {
            using (var db = new PetDBContext())
            {
                // Consulta la base de datos para obtener los nombres de los clientes y sus ID
                var nombresClientes = db.Cliente.Select(cliente => new
                {
                    Id = cliente.IdCliente,
                    Nombre = cliente.NombreCompleto
                }).ToList();

                // Asigna la lista de nombres al ComboBox
                comboBox1.DataSource = nombresClientes;
                comboBox1.DisplayMember = "Nombre";  // Muestra el nombre del cliente
                comboBox1.ValueMember = "Id";        // Almacena el ID del cliente
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
