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
    public partial class MantenedorProductos : Form
    {
        public MantenedorProductos()
        {
            InitializeComponent();
        }

        private void dgvListadoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Productos", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvListadoProductos.DataSource = tabla;
        }

        private void btnAtrasProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entProductos Pro = new entProductos();
            Pro.idProducto = int.Parse(txtIdProducto.Text.Trim());
            Pro.nombreProducto = txtNombreProducto.Text.Trim();
            Pro.stockProducto = int.Parse(txtStockProducto.Text.Trim());
            Pro.precioPro = int.Parse(txtPrecioProducto.Text.Trim());
            logProductos.Instancia.EliminaProductos(Pro);
        }

        private void dgvListadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvListadoProductos.Rows[e.RowIndex];
            txtIdProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNombreProducto.Text = filaActual.Cells[1].Value.ToString();
            txtStockProducto.Text = filaActual.Cells[2].Value.ToString();
            txtPrecioProducto.Text = filaActual.Cells[3].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProductos Pro = new entProductos();
                Pro.nombreProducto = txtNombreProducto.Text.Trim();
                Pro.stockProducto = int.Parse(txtStockProducto.Text.Trim());
                Pro.precioPro = int.Parse(txtPrecioProducto.Text.Trim());
                logProductos.Instancia.InsertaProductos(Pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = "";
            txtNombreProducto.Text = "";
            txtStockProducto.Text = "";
            txtPrecioProducto.Text = "";
        }
    }
}
