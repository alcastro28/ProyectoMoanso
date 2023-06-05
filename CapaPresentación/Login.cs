using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)  {  }
        private void Boton_entrar_login_Click(object sender, EventArgs e)
        {
            Form FormLogin = new Inicio();
            FormLogin.Show();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_entrar_login_Click(object sender, EventArgs e)
        {
            Form FormLogin = new Inicio();
            FormLogin.Show();
            this.Hide();
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
