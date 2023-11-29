using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetApp
{
    public partial class frmNewWeight : Form
    {
        public frmNewWeight(int idPesoSeleccionado)
        {
            InitializeComponent();
        }

        private void frmEditWeight_Load(object sender, EventArgs e)
        {
            using (var db = new PetDBContext())
            {
                // Consulta la base de datos para obtener los nombres de los clientes y sus ID
                var nombremascota = db.Mascota.Select(Mascota => new
                {
                    Id = Mascota.IdMascota,
                    Nombre = Mascota.Alias
                }).ToList();

                // Asignar la lista de nombres al ComboBox
                cbxnamemascota.DataSource = nombremascota;
                cbxnamemascota.DisplayMember = "Nombre";
                cbxnamemascota.ValueMember = "Id";


            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using( var db = new PetDBContext())
            {
                //obtenemos el id de la mascota seleccionada
                int idMascotaSeleccionada = (int)cbxnamemascota.SelectedValue;

                var nuevoPeso = new Pesos()
                {
                    IdMascota = idMascotaSeleccionada,
                    Fecha = dtFecha.Value,
                    Peso = txtPeso.Text
                };
                //Guardamos los cambios 
                db.Pesos.Add(nuevoPeso);
                db.SaveChanges();

                MessageBox.Show("Peso guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Cerramos el formulario después de guardar
                this.Close();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

