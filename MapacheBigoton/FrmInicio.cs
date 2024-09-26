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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // FrmAgregarCita agregarCita = new FrmAgregarCita(frmCitaRegistrada);
          //  agregarCita.Show();
          FrmAgregarCita agregarCita = new FrmAgregarCita();
            agregarCita.Show();
        }

        private void btnCitasRegistradas_Click(object sender, EventArgs e)
        {
          // FrmCitasRegistradas.show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
