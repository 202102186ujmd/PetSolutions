using PetApp;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmMantoUsuarios : Form
    {
        private Usuarios usuarioSeleccionado; // Almacenar el usuario seleccionado

        public frmMantoUsuarios()
        {
            InitializeComponent();
        }

        private void frmMantoUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            using (var db = new PetDBContext())
            {
                grdData.DataSource = db.Usuarios.ToList(); // Cargar usuarios desde la base de datos
                grdData.Columns["Contrasena"].Visible = false; // Ocultar la contraseña
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            if (grpEdit.Visible == true)
            {
                grpEdit.Visible = false;
                btnEditar.Text = "Editar";
                btnnclose.Visible = true;
                btnnuevo.Visible = true;

            }
            else
            {
                grpEdit.Visible = true;
                btnEditar.Text = "Cancelar";
                btnnclose.Visible = false;
                btnnuevo.Visible = false;

            }


            if (grdData.SelectedRows.Count > 0)
            {
                // Obtener el usuario seleccionado
                string emailUsuarioSeleccionado = grdData.SelectedRows[0].Cells["Email"].Value.ToString();

                using (var db = new PetDBContext())
                {
                    // Buscar al usuario en la base de datos por dirección de correo electrónico
                    usuarioSeleccionado = db.Usuarios.FirstOrDefault(u => u.Email == emailUsuarioSeleccionado);

                    if (usuarioSeleccionado != null)
                    {
                        // Mostrar los datos del usuario en los controles de edición
                        txtemail.Text = usuarioSeleccionado.Email;
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btndelete_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado != null)
            {
                // Confirmar la eliminación
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (var db = new PetDBContext())
                    {
                        // Eliminar el usuario de la base de datos
                        db.Entry(usuarioSeleccionado).State = EntityState.Deleted;
                        db.SaveChanges();
                    }

                    // Actualizar la vista de usuarios
                    CargarUsuarios();

                    // Limpiar los controles y ocultar el formulario de edición
                    LimpiarControlesEdicion();
                }
            }
        }

        private void LimpiarControlesEdicion()
        {
            txtemail.Text = "";
            grpEdit.Visible = false;
            btnEditar.Text = "Editar";
            btnnclose.Visible = true;
            btnnuevo.Visible = true;
            usuarioSeleccionado = null;
        }

        private void btnnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncanel_Click(object sender, EventArgs e)
        {
            
            grpEdit.Visible = false;
            btnEditar.Text = "Editar";
            btnnclose.Visible = true;
            btnnuevo.Visible = true;
            LimpiarControlesEdicion();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            //mostrar el formulario de creacion de usuario
            var NewUser = new frmNewUser();
            NewUser.ShowDialog();

            // Después de cerrar el formulario de creación de usuario, cargar los datos actualizados
            CargarUsuarios();

        }
    }
}
