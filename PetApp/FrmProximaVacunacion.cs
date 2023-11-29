using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetApp
{
    public partial class FrmProximaVacunacion : Form
    {
        public FrmProximaVacunacion()
        {
            InitializeComponent();
        }

        private void FrmProximaVacunacion_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
        }
        private void CargarDatosEnDataGridView()
        {
            using (var db = new PetDBContext())
            {
                // Realiza la consulta y carga los datos en el DataGridView
                var consulta = from mascota in db.Mascota
                               join vacuna in db.Vacunas on mascota.IdMascota equals vacuna.IdMascota
                               select new
                               {
                                   Mascota = mascota.Alias,
                                   FechaProxima = vacuna.FechaProxima,
                                   Enfermedad = vacuna.Enfermedad
                               };

                dataGridView.DataSource = consulta.ToList();
            }
        }
    }
}
