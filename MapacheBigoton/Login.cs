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
    public partial class Login : Form
    {
        private Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "admin", "12345" },
            { "Yissel", "123456" },
            { "Kareen", "1234567" }
        };
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "12345";

            string username1 = "Yissel";
            string password1 = "123456";

            string username2 = "Kareen";
            string password2 = "1234567";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (usuarios.ContainsKey(username) && usuarios[username] == password)
            {
                // Usuario y contraseña correctos, abrir el formulario FrmInicio
                FrmInicio frmInicio = new FrmInicio();
                frmInicio.Show();
                this.Hide();
            }
            else
            {
                // Usuario o contraseña incorrectos, mostrar mensaje de error
                MessageBox.Show("Datos incorrectos. Por favor, inténtelo nuevamente.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
