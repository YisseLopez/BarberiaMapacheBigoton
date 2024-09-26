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
    public partial class FrmAgregarCita : Form
    {
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
        public FrmAgregarCita()
        {
            InitializeComponent();
            comboboxTipoServicio();
            comboboxHorario();
            comboboxBarbero();
            
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
                // Fecha = dtpSeleccionarDia.Value.Date.Add(DateTime.Parse(cbHora.SelectedItem.ToString()).TimeOfDay),
                Fecha = dtpSeleccionarDia.Value,
                Barbero = cbBarbero.SelectedItem.ToString(),
                Hora = cbHora.SelectedItem.ToString(),
            };

            //FrmCitasRegistradas.AgregarCita(nuevaCita);
            txtNombreCliente.Clear();
            txtTelefono.Clear();
            cbServicioSolicitado.Items.Clear();
            txtCostoServicio.Clear();
            cbHora.Items.Clear();
            cbBarbero.Items.Clear();
        }
    }
}
