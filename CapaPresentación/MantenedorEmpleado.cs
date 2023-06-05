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
using CapaDatos;
using CapaEntidad;
using CapaLogica;

namespace CapaPresentación
{
    public partial class MantenedorEmpleado : Form
    {
        public MantenedorEmpleado()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void listaEmpleado()
        {
            dgvEmpleado.DataSource = logEmpleado.Instancia.ListaEmpleados();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalirInicio_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entEmpleados em = new entEmpleados();
                em.nombreEmpleado = txtNombreEmpleado.Text.Trim();
                em.apellidoEmpleado = txtApellidoEmpleado.Text.Trim();
                em.direccionEmpleado = txtDireccionEmpleado.Text.Trim();
                em.telefonoEmpleado = txtTelefonoEmpleado.Text.Trim();
                em.emailEmpleado = txtEmailEmpleado.Text.Trim();
                em.sexo = char.Parse(cboSexo.Text.Trim());
                em.fechaNacimiento = dtpFechaNacimiento.Value;
                logEmpleado.Instancia.InsertaEmpleado(em);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnMostrarEmpleado_Click(object sender, EventArgs e)
        {
            //Iniciando Conexion con la Base de Datos
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Empleados", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvEmpleado.DataSource = tabla;
        }
        
        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleados em = new entEmpleados();
                em.idEmpleado = int.Parse(txtCodigoEmpleado.Text.Trim());
                em.nombreEmpleado = txtNombreEmpleado.Text.Trim();
                em.apellidoEmpleado = txtApellidoEmpleado.Text.Trim();
                em.direccionEmpleado = txtDireccionEmpleado.Text.Trim();
                em.telefonoEmpleado = txtTelefonoEmpleado.Text.Trim();
                em.emailEmpleado = txtEmailEmpleado.Text.Trim();
                em.sexo = char.Parse(cboSexo.Text.Trim());
                em.fechaNacimiento = dtpFechaNacimiento.Value;
                logEmpleado.Instancia.EditaEmpleado(em);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaEmpleado();
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEmpleado.Rows[e.RowIndex];
            txtCodigoEmpleado.Text = filaActual.Cells[0].Value.ToString();
            txtNombreEmpleado.Text = filaActual.Cells[1].Value.ToString();
            txtApellidoEmpleado.Text = filaActual.Cells[2].Value.ToString();
            txtDireccionEmpleado.Text = filaActual.Cells[3].Value.ToString();
            txtTelefonoEmpleado.Text = filaActual.Cells[4].Value.ToString();
            txtEmailEmpleado.Text = filaActual.Cells[5].Value.ToString();
            cboSexo.Text = filaActual.Cells[6].Value.ToString();
            dtpFechaNacimiento.Text = filaActual.Cells[7].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoEmpleado.Text = "";
            txtNombreEmpleado.Text = "";
            txtTelefonoEmpleado.Text = "";
            txtApellidoEmpleado.Text = "";
            txtDireccionEmpleado.Text = "";
            txtEmailEmpleado.Text = "";
            cboSexo.Text = "";
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MantenedorEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
