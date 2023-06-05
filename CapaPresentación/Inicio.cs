using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames; 

namespace CapaPresentación
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_empleado_inicio_Click(object sender, EventArgs e)
        {
            Form FormularioEmpleado = new MantenedorEmpleado();
            FormularioEmpleado.Show();
        }

        private void btn_venta_inicio_Click(object sender, EventArgs e)
        {
            Form FormularioVenta = new CoreVenta();
            FormularioVenta.Show();
        }

        private void btn_cliente_inicio_Click(object sender, EventArgs e)
        {
            Form FormularioCliente = new MantenedorCliente();
            FormularioCliente.Show();

        }

        private void btn_proveedores_inicio_Click(object sender, EventArgs e)
        {
            Form FormularioProvedores = new MantenedorProveedores();
            FormularioProvedores.Show();
        }

        private void btnSalirInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            Form FormularioLogin = new Login();
            FormularioLogin.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form FormularioProductos = new MantenedorProductos();
            FormularioProductos.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form FormularioMantenimiento = new MantenedorMantenimiento();
            FormularioMantenimiento.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form FormularioReserva = new MantenedorReserva();
            FormularioReserva.Show();
        }
    }
}
