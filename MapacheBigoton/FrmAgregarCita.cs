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
            public string Telefono { get; set; }

            
        }
        public FrmAgregarCita()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
