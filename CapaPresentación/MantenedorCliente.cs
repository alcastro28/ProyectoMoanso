using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace CapaPresentación {
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            listarCliente();
        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void btn_editar_clienteM_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.idClientes = int.Parse(txtidCliente.Text.Trim());
                c.razonSocial = txtRazonSocial.Text.Trim();
                c.idTipoCliente = comboBoxCLiente.Text.Trim();
                c.Nombre = txtNombre.Text.Trim();
                c.Apellidos = tctApellido.Text.Trim();
                c.DNI = txtDNI.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.CorreoElectronico = txtCorreo.Text.Trim();
                c.Ciudad = cbxCiudad.Text.Trim();
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarCliente();
            
        }
        private void btn_cancelar_clienteM_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btn_agregar_clienteM_Click(object sender, EventArgs e)
        {
             try
            {
                entCliente c = new entCliente();
                c.razonSocial = txtRazonSocial.Text.Trim();
                c.idTipoCliente = comboBoxCLiente.Text.Trim();
                c.Nombre = txtNombre.Text.Trim();
                c.Apellidos = tctApellido.Text.Trim();
                c.DNI = txtDNI.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.CorreoElectronico = txtCorreo.Text.Trim();
                c.Ciudad = cbxCiudad.Text.Trim();
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarCliente();
            
        }
        private void btn_mostrar_clienteM_Click(object sender, EventArgs e) {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Clientes", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvCliente.DataSource = tabla;
        }
        private void btn_nuevo_clienteM_Click(object sender, EventArgs e) {
            txtidCliente.Text = "";
            txtRazonSocial.Text = "";
            comboBoxCLiente.Text = "";
            txtNombre.Text = "";
            tctApellido.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            cbxCiudad.Text = "";
        }
        private void LimpiarVariables(){
            txtidCliente.Text = "";
            txtRazonSocial.Text = "";
            comboBoxCLiente.Text = "";
            txtNombre.Text = "";
            tctApellido.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            cbxCiudad.Text = "";
        }
        private void MantenedorCliente_Load(object sender, EventArgs e) { }
        private void dg_muestra_clientesP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
         private void dg_muestra_clientesP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            txtidCliente.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
            comboBoxCLiente.Text = filaActual.Cells[2].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString();
            tctApellido.Text = filaActual.Cells[4].Value.ToString();
            txtDNI.Text = filaActual.Cells[5].Value.ToString();
            txtDireccion.Text = filaActual.Cells[6].Value.ToString();
            txtCorreo.Text = filaActual.Cells[7].Value.ToString();
            cbxCiudad.Text = filaActual.Cells[8].Value.ToString();
            cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[9].Value);
            dtPickerRegCliente.Text = filaActual.Cells[10].Value.ToString();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
