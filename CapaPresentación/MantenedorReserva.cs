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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class MantenedorReserva : Form
    {
        public MantenedorReserva()
        {
            InitializeComponent();
            listarReserva();
            LLenarComboxCliente();
            LLenarComboxProductos();
        }

        public void listarReserva() {
            dgvReserva.DataSource = logReserva.Instancia.ListarReserva();
        
        }

        private DataTable productos_cb()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Productos", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
        private void LLenarComboxProductos()
        {
            cmbIDProducto.DataSource = productos_cb();

            cmbIDProducto.DisplayMember = "nombreProducto";
            cmbIDProducto.ValueMember = "idProducto";
        }
        private void LLenarComboxCliente()
        {
            cmbIDcliente.DataSource = logCliente.Instancia.ListarCliente();

            cmbIDcliente.DisplayMember = "idClientes";
            cmbIDcliente.ValueMember = "idClientes";
        }
        private void btn_nuevo_clienteM_Click(object sender, EventArgs e)
        {
            txtIDreserva.Text = "";
            cmbIDcliente.ResetText();
            cmbIDProducto.ResetText();
        }

        private void btn_mostrar_clienteM_Click(object sender, EventArgs e)
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Reserva", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvReserva.DataSource = tabla;
        }

        private void btn_agregar_clienteM_Click(object sender, EventArgs e)
        {
            try
            {
                entReserva c = new entReserva();
                c.idReserva = int.Parse(txtIDreserva.Text.Trim());
                c.fecha = dtFecha.Value;
                c.idClientes = int.Parse(Convert.ToString(cmbIDcliente.SelectedValue));
                c.idProducto = int.Parse(Convert.ToString(cmbIDProducto.SelectedValue));
                c.estReserva = cbkEstadoReserva.Checked;
                logReserva.Instancia.InsertarReserva(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarReserva();
        }

        private void btn_editar_clienteM_Click(object sender, EventArgs e)
        {
            try
            {
                entReserva c = new entReserva();
                c.idReserva = int.Parse(txtIDreserva.Text.Trim());
                c.fecha = dtFecha.Value;
                c.idClientes = int.Parse(Convert.ToString(cmbIDcliente.SelectedValue));
                c.idProducto = int.Parse(Convert.ToString(cmbIDProducto.SelectedValue));
                c.estReserva = cbkEstadoReserva.Checked;
                logReserva.Instancia.EditarReserva(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarReserva();
        }

        private void btn_cancelar_clienteM_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entReserva Pro = new entReserva();
            Pro.idReserva = int.Parse(txtIDreserva.Text.Trim());
            Pro.fecha = dtFecha.Value;
            Pro.estReserva = cbkEstadoReserva.Checked;
            logReserva.Instancia.EliminarReserva(Pro);
            listarReserva();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvReserva.DataSource = logReserva.Instancia.BuscarReserva(Convert.ToInt32(txt_buscar.Text));
        }
    }
}
