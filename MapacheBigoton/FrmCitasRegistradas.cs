using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapacheBigoton
{
    public partial class FrmCitasRegistradas : Form
    {
        public FrmCitasRegistradas()
        {
            InitializeComponent();
            dgvCitasAgendadas.ColumnCount = 7;
            dgvCitasAgendadas.Columns[0].Name = "Nombre del cliente";
            dgvCitasAgendadas.Columns[1].Name = "Telefono";
            dgvCitasAgendadas.Columns[2].Name = "Servicio solicitado";
            dgvCitasAgendadas.Columns[3].Name = "Costo del servicio";
            dgvCitasAgendadas.Columns[4].Name = "Hora del servicio";
            dgvCitasAgendadas.Columns[5].Name = "Fecha del servicio";
            dgvCitasAgendadas.Columns[6].Name = "Barbero que realizará el servicio";
        }

        public void AgregarCita(FrmAgregarCita.Cita cita)
        {
            string[] row = {
                cita.NombreCliente,
                cita.Telefono,
                cita.ServicioSolicitado,
                cita.Hora
            };
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
