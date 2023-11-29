using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si las contraseñas coinciden
                if (txtPass1.Text != txtPass2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                    return;
                }

                using (var db = new PetDBContext())
                {
                    // Option 1: Creación de Usuario

                    // Creación de parámetros
                    var option = new SqlParameter("@Option", 1);
                    var email = new SqlParameter("@Email", txtEmail.Text);
                    var password = new SqlParameter("@Password", txtPass1.Text);

                    // Llamada al procedimiento almacenado y obtención del resultado
                    var resultado = db.Database
                        .SqlQuery<string>("EXEC sp_Login @Option, @Email, @Password", option, email, password)
                        .SingleOrDefault();

                    if (resultado == "Usuario creado exitosamente.")
                    {
                        MessageBox.Show("Usuario creado con éxito.");
                        // Puedes realizar cualquier acción adicional aquí, como redirigir al usuario a la página de inicio de sesión.
                        this.Close();
                    }
                    else if (resultado == "El correo electrónico ya está registrado.")
                    {
                        MessageBox.Show("El correo electrónico ya está registrado. Por favor, use otro correo electrónico.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el usuario. Por favor, inténtelo de nuevo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
