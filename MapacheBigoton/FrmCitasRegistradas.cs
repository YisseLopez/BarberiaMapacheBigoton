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

namespace MapacheBigoton
{
    public partial class FrmCitasRegistradas : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BarberiaBD"].ConnectionString;

        public void Refrescar()
        {
            dgvCitasAgendadas.ColumnCount = 7;
            dgvCitasAgendadas.Columns[0].Name = "Nombre del cliente";
            dgvCitasAgendadas.Columns[1].Name = "Telefono";
            dgvCitasAgendadas.Columns[2].Name = "Servicio solicitado";
            dgvCitasAgendadas.Columns[3].Name = "Costo del servicio";
            dgvCitasAgendadas.Columns[4].Name = "Hora del servicio";
            dgvCitasAgendadas.Columns[5].Name = "Fecha del servicio";
            dgvCitasAgendadas.Columns[6].Name = "Barbero que realizará el servicio";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Citas";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvCitasAgendadas.Rows.Add(
                                    reader["NombreCliente"].ToString(),
                                    reader["Telefono"].ToString(),
                                    reader["ServicioSolicitado"].ToString(),
                                    Convert.ToDecimal(reader["Costo"]).ToString("C"),
                                    reader["Hora"].ToString(),
                                    Convert.ToDateTime(reader["Fecha"]).ToShortDateString(),
                                    reader["Barbero"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
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
            Refrescar();
        }
        public void AgregarCita(FrmAgregarCita.Cita cita)
        {
            string[] row = {
                cita.NombreCliente,
                cita.Telefono,
                cita.ServicioSolicitado,
                cita.Costo.ToString("C"),
                cita.Hora,
                cita.Fecha.ToShortDateString(),
                cita.Barbero
            };
           dgvCitasAgendadas.Rows.Add(row);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
