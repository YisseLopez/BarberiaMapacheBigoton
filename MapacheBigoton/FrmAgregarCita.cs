using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MapacheBigoton
{
    public partial class FrmAgregarCita : Form
    {
        private FrmCitasRegistradas _frmCitasRegistradas;
        public class Cita
        {
            public string NombreCliente { get; set; }
            public string ServicioSolicitado { get; set; }
            public decimal Costo { get; set; }
            public string Telefono { get; set; }
            public DateTime Fecha { get; set; }
            public string Hora  { get; set; }
            public string Barbero { get; set; }

            public static List<Cita> listaCitas = new List<Cita>();

        }
        public FrmAgregarCita(FrmCitasRegistradas frmCitasRegistradas)
        {
            InitializeComponent();
            comboboxTipoServicio();
            comboboxHorario();
            comboboxBarbero();
            _frmCitasRegistradas = frmCitasRegistradas;
            
        }
        private void comboboxTipoServicio()
        {
            cbServicioSolicitado.Items.Add("Corte de cabello");
            cbServicioSolicitado.Items.Add("Afeitado");
            cbServicioSolicitado.Items.Add("Corte y barba");
            cbServicioSolicitado.Items.Add("Corte y depilacion de ceja");
            cbServicioSolicitado.Items.Add("Depilacion de ceja y barba");
        }

        private void comboboxHorario()
        {
            cbHora.Items.Add("09:00 AM");
            cbHora.Items.Add("10:00 AM");
            cbHora.Items.Add("11:00 AM");
            cbHora.Items.Add("12:00 PM");
            cbHora.Items.Add("01:00 PM");
            cbHora.Items.Add("02:00 PM");
            cbHora.Items.Add("03:00 PM");
            cbHora.Items.Add("04:00 PM");
        }

        private void comboboxBarbero()
        {
            cbBarbero.Items.Add("Yissel");
            cbBarbero.Items.Add("Karen");
            cbBarbero.Items.Add("Lesly");
            cbBarbero.Items.Add("Carmen");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Cita nuevaCita = new Cita()
            {
                NombreCliente = txtNombreCliente.Text,
                Telefono = txtTelefono.Text,
                ServicioSolicitado = cbServicioSolicitado.SelectedItem.ToString(),
                Costo = Convert.ToDecimal(txtCostoServicio.Text),
                Fecha = dtpSeleccionarDia.Value,
                Barbero = cbBarbero.SelectedItem.ToString(),
                Hora = cbHora.SelectedItem.ToString(),
            };

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BarberiaBD"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Citas (NombreCliente, Telefono, ServicioSolicitado, Costo, Fecha, Barbero, Hora) " +
                                   "VALUES (@NombreCliente, @Telefono, @ServicioSolicitado, @Costo, @Fecha, @Barbero, @Hora)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreCliente", nuevaCita.NombreCliente);
                        command.Parameters.AddWithValue("@Telefono", nuevaCita.Telefono);
                        command.Parameters.AddWithValue("@ServicioSolicitado", nuevaCita.ServicioSolicitado);
                        command.Parameters.AddWithValue("@Costo", nuevaCita.Costo);
                        command.Parameters.AddWithValue("@Fecha", nuevaCita.Fecha);
                        command.Parameters.AddWithValue("@Barbero", nuevaCita.Barbero);
                        command.Parameters.AddWithValue("@Hora", nuevaCita.Hora);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                _frmCitasRegistradas = new();
                _frmCitasRegistradas.AgregarCita(nuevaCita);
                _frmCitasRegistradas.Refrescar();
                MessageBox.Show("Cita agendada correctamente");
                _frmCitasRegistradas.Show();

                txtNombreCliente.Clear();
                txtTelefono.Clear();
                txtCostoServicio.Clear();
                cbServicioSolicitado.SelectedIndex = -1;
                cbBarbero.SelectedIndex = -1;
                cbHora.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

            //istaCitas.Add(nuevaCita);


            //FrmCitasRegistradas frmCitasRegistradas = new FrmCitasRegistradas();
            //frmCitasRegistradas.Show();
            // this.Close();
        }

    }
}
