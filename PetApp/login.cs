using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btningresarLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PetDBContext())
                {
                    // Option 2: Login

                    // Creación de parámetros
                    var option = new SqlParameter("@Option", 2);
                    var email = new SqlParameter("@Email", txbusuario.Text);
                    var password = new SqlParameter("@Password", txbpassword.Text);

                    // Llamada al procedimiento almacenado y obtención del resultado
                    var resultado = db.Database
                        .SqlQuery<string>("EXEC sp_Login @Option, @Email, @Password", option, email, password)
                        .SingleOrDefault();

                    if (resultado == "Inicio de sesión exitoso.")
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        var myfrmmain = new frmMain();
                        this.Hide();
                        myfrmmain.ShowDialog();
                        this.Close();
                    }
                    else if (resultado == "La contraseña no es válida.")
                    {
                        MessageBox.Show("La contraseña no es válida. Por favor, inténtelo de nuevo.");
                    }
                    else if (resultado == "El usuario no existe.")
                    {
                        MessageBox.Show("El usuario no existe.");
                    }
                    else
                    {
                        MessageBox.Show("Error desconocido al iniciar sesión.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btncancelarlogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
