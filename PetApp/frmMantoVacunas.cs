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
    public partial class frmMantoVacunas : Form
    {
        public frmMantoVacunas()
        {
            InitializeComponent();
            CargarUsuarios();   // Cargar usuarios en el DataGridView
        }

        private void frmMantoVacunas_Load(object sender, EventArgs e)
        {
            ConfigurarCombobox(); // Cargar usuarios en el ComboBox
        }
        private void CargarUsuarios()
        {
            using (var db = new PetDBContext())
            {
                // Cargar usuarios en el DataGridView
                dataGridView.DataSource = db.Vacunas.ToList(); // Cargar usuarios desde la base de datos
            }
        }
        private void ConfigurarCombobox()
        {
            //configuracion del combobox
            using (var db = new PetDBContext())
            {
                //Consultar la base de datos para obtener los nombres de las mascotas y sus ID
                var nombremascota = db.Mascota.Select(Mascota => new
                {
                    Id = Mascota.IdMascota,
                    Nombre = Mascota.Alias
                }).ToList();

                // Asignar la lista de nombres al ComboBox
                cbxmascota.DataSource = db.Mascota.ToList(); // Cargar usuarios desde la base de datos
                cbxmascota.DisplayMember = "Alias"; // Mostrar solamente el nombre del usuario
                cbxmascota.ValueMember = "IdMascota"; // El valor de cada elemento es el ID de la mascota
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (Edicion.Visible == true)
            {
                Edicion.Visible = false;
                btnagregar.Text = "Agregar";
                btneditar.Visible = true;
                btneliminar.Visible = true;

            }
            else
            {
                Edicion.Visible = true;
                btnagregar.Text = "Cancelar";
                btneditar.Visible = false;
                btneliminar.Visible = false;
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (Edicion.Visible == true)
            {
                Edicion.Visible = false;
                btneditar.Text = "Editar";
                btnagregar.Visible = true;
                btneliminar.Visible = true;
            }
            else
            {
                Edicion.Visible = true;
                btneditar.Text = "Cancelar";
                btnagregar.Visible = false;
                btneliminar.Visible = false;
                btnactualizar.Visible = true;
                button.Visible = true;
                btnsave.Visible = false;
                btncancel.Visible = false;
            }

            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la mascota seleccionada
                int idMascotaSeleccionada = (int)dataGridView.SelectedRows[0].Cells["IdMascota"].Value;

                using (var db = new PetDBContext())
                {
                    // Consultar la base de datos para obtener el registro de la vacuna que se va a editar
                    var vacunaAEditar = db.Vacunas.FirstOrDefault(p => p.IdMascota == idMascotaSeleccionada);

                    if (vacunaAEditar != null)
                    {
                        // Consulta la base de datos para obtener la lista de nombres de mascotas
                        var nombremascota = db.Mascota.Select(Mascota => new
                        {
                            Id = Mascota.IdMascota,
                            Nombre = Mascota.Alias
                        }).ToList();
                        // Asigna la lista de nombres al ComboBox
                        cbxmascota.DataSource = nombremascota;
                        cbxmascota.DisplayMember = "Nombre";  // Muestra el nombre del Mascota
                        cbxmascota.ValueMember = "Id"; // Almacena el ID de la Mascota

                        // Verifica si vacunaAEditar.IdMascota tiene un valor válido
                        if (vacunaAEditar.IdMascota != null)
                        {
                            // Establece el valor seleccionado en el ComboBox
                            cbxmascota.SelectedValue = vacunaAEditar.IdMascota;
                        }

                        // Asignar los valores de la mascota seleccionada a los controles de edición
                        txbenfermedad.Text = dataGridView.SelectedRows[0].Cells["Enfermedad"].Value.ToString();
                        // Obtener la fecha de la celda correspondiente en la fila seleccionada
                        if (DateTime.TryParse(dataGridView.SelectedRows[0].Cells["Fecha"].Value.ToString(), out DateTime fecha))
                        {
                            // Asignar la fecha al DateTimePicker
                            dtpregsitro.Value = fecha;
                        }
                        if (DateTime.TryParse(dataGridView.SelectedRows[0].Cells["FechaProxima"].Value.ToString(), out DateTime FechaProxima))
                        {
                            // Asignar la fecha al DateTimePicker
                            dtpnextregistro.Value = FechaProxima;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecciona una mascota para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una mascota para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                //obtenemos el id de la mascota seleccionada
                int idMascotaSeleccionada = (int)dataGridView.SelectedRows[0].Cells["IdMascota"].Value;

                //preguntamos al usuario si esta seguro de eliminar la mascota
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminar esta mascota?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(respuesta == DialogResult.Yes)
                {
                    using(var db = new PetDBContext())
                    {
                        //buscamos la mascota en la base de datos por su id
                        var mascota = db.Vacunas.FirstOrDefault(m => m.IdMascota == idMascotaSeleccionada);

                        if(mascota != null)
                        {
                            //eliminamos la mascota de la base de datos
                            db.Vacunas.Remove(mascota);
                            db.SaveChanges();

                            //actualizamos el datagridview para reflejar los cambios
                            dataGridView.DataSource = db.Vacunas.ToList();

                            //mostramos un mensaje de confirmacion
                            MessageBox.Show("El registro se elimino correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } 
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una mascota para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using(var db = new PetDBContext())
            {
                //obtenemos el id de la mascota seleccionada
                int idMascotaSeleccionada = (int)cbxmascota.SelectedValue;

                var nuevaVacuna = new Vacunas()
                {
                    IdMascota = idMascotaSeleccionada,
                    Fecha = dtpregsitro.Value,
                    Enfermedad = txbenfermedad.Text,
                    FechaProxima = dtpnextregistro.Value
                };
                db.Vacunas.Add(nuevaVacuna);
                db.SaveChanges();//Guardamos los cambios
                #region
                dataGridView.DataSource = db.Vacunas.ToList(); //actualizamos el datagridview para reflejar los cambios
                LimpiarControlesEdicion(); //limpiamos los controles de edicion
                Edicion.Visible = false;  //ocultamos el panel de edicion y restauramos el boton agregar
                btnagregar.Text = "Agregar";
                btnagregar.Visible = true;
                btneditar.Visible = true;
                btneliminar.Visible = true;
                #endregion
            }
        }

        private void LimpiarControlesEdicion()
        {
            txbenfermedad.Text = string.Empty;
            dtpregsitro.Value = DateTime.Now;
            dtpnextregistro.Value = DateTime.Now;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //limpiamos los controles de edicion
            LimpiarControlesEdicion();
            //ocultamos el panel de edicion y restauramos el boton agregar
            Edicion.Visible = false;
            btnagregar.Text = "Agregar";
            btnagregar.Visible = true;
            btneditar.Visible = true;
            btneliminar.Visible = true;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            // Obtener el valor del ID de la mascota seleccionada
            int idMascotaSeleccionada = (int)dataGridView.SelectedRows[0].Cells["IdMascota"].Value;

            using (var db = new PetDBContext())
            {
                // Consultar la base de datos para obtener el registro de la vacuna que se va a editar
                var vacunaAEditar = db.Vacunas.FirstOrDefault(p => p.IdMascota == idMascotaSeleccionada);

                if (vacunaAEditar != null)
                {
                    //Actualizar los datos del registro de vacuna con los valores de los controles
                    vacunaAEditar.IdMascota = (int)cbxmascota.SelectedValue;
                    vacunaAEditar.Fecha = dtpregsitro.Value;
                    vacunaAEditar.Enfermedad = txbenfermedad.Text;
                    vacunaAEditar.FechaProxima = dtpnextregistro.Value;

                    // Guardar los cambios
                    db.SaveChanges();
                    // Actualizar el DataGridView para reflejar los cambios
                    dataGridView.DataSource = db.Vacunas.ToList();
                    // Limpiar los controles de edición
                    LimpiarControlesEdicion();

                    // Mostrar un mensaje de confirmación
                    MessageBox.Show("El registro se actualizo correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Ocultar el panel de edición y restaurar el botón "Editar"
                    Edicion.Visible = false;
                    btneditar.Text = "Editar";
                    btnagregar.Visible = true;
                    btneliminar.Visible = true;
                    btnactualizar.Visible = false;
                    button.Visible = false;

                }
                else
                {
                    MessageBox.Show("Selecciona una mascota para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //Limpiar los controles de edición
            LimpiarControlesEdicion();
            //Ocultar el panel de edición y restaurar el botón "Editar"
            Edicion.Visible = false;
            btneditar.Text = "Editar";
            btnagregar.Visible = true;
            btneliminar.Visible = true;
            btnactualizar.Visible = false;
            button.Visible = false;
        }
    }
}
