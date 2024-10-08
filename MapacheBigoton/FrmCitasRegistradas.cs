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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                if (dgvCitasAgendadas.SelectedRows.Count > 0) // Verifica que haya una fila seleccionada
                {
                    // Obtiene los datos de la fila seleccionada
                    string nombreCliente = dgvCitasAgendadas.SelectedRows[0].Cells["Nombre del cliente"].Value.ToString();
                    string telefono = dgvCitasAgendadas.SelectedRows[0].Cells["Telefono"].Value.ToString();

                    // Confirmar la eliminación
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta cita?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            // Eliminar de la base de datos
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string query = "DELETE FROM Citas WHERE NombreCliente = @NombreCliente AND Telefono = @Telefono";

                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                                    command.Parameters.AddWithValue("@Telefono", telefono);

                                    int filasAfectadas = command.ExecuteNonQuery();

                                    if (filasAfectadas > 0)
                                    {
                                        // Si la cita se eliminó de la base de datos, eliminar la fila del DataGridView
                                        dgvCitasAgendadas.Rows.RemoveAt(dgvCitasAgendadas.SelectedRows[0].Index);
                                        MessageBox.Show("Cita eliminada correctamente.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo eliminar la cita. Inténtelo de nuevo.");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error al eliminar la cita: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una cita para eliminar.");
                }
            }

        }
    }
