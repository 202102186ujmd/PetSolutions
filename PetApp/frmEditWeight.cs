using System;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmEditWeight : Form
    {
        protected int _IdRegistroPeso; // Variable para almacenar el ID del registro de peso

        public frmEditWeight(int idPesoSeleccionado)
        {
            InitializeComponent();
            _IdRegistroPeso = idPesoSeleccionado; // Asigna el ID del registro de peso al campo de clase
        }

        private void frmEditWeight_Load(object sender, EventArgs e)
        {
            using (var db = new PetDBContext())
            {
                // Consulta la base de datos para obtener el registro de peso que se va a editar
                var pesoAEditar = db.Pesos.FirstOrDefault(p => p.Id == _IdRegistroPeso);

                if (pesoAEditar != null)
                {
                    // Consulta la base de datos para obtener la lista de nombres de mascotas
                    var nombremascota = db.Mascota.Select(Mascota => new
                    {
                        Id = Mascota.IdMascota,
                        Nombre = Mascota.Alias
                    }).ToList();

                    // Asigna la lista de nombres al ComboBox
                    cbxnamemascota.DataSource = nombremascota;
                    cbxnamemascota.DisplayMember = "Nombre";  // Muestra el nombre del cliente
                    cbxnamemascota.ValueMember = "Id"; // Almacena el ID de la Mascota

                    // Verifica si pesoAEditar.IdMascota tiene un valor válido
                    if (pesoAEditar.IdMascota != null)
                    {
                        // Establece el valor seleccionado en el ComboBox
                        cbxnamemascota.SelectedValue = pesoAEditar.IdMascota;
                    }

                    dtFecha.Value = pesoAEditar.Fecha ?? DateTime.Now;
                    txtPeso.Text = pesoAEditar.Peso;
                }
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (var db = new PetDBContext())
            {
                // Obtener el registro de peso que se va a editar
                var pesoAEditar = db.Pesos.FirstOrDefault(p => p.Id == _IdRegistroPeso);

                if (pesoAEditar != null)
                {
                    // Actualizar los datos del registro de peso con los valores de los controles
                    pesoAEditar.IdMascota = (int)cbxnamemascota.SelectedValue;
                    pesoAEditar.Fecha = dtFecha.Value;
                    pesoAEditar.Peso = txtPeso.Text;

                    // Guardar los cambios
                    db.SaveChanges();

                    MessageBox.Show("Peso actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cerrar el formulario después de guardar
                    this.Close();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
