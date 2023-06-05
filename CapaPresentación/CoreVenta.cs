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
    public partial class CoreVenta : Form
    {
        public CoreVenta()
        {
            InitializeComponent();
            listarVentas();
        }
        private void label3_Click(object sender, EventArgs e) { }

        private void mostrar()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Ventiña", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgv_ventas.DataSource = tabla;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Dispose();

        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                entVenta venta = new entVenta();
                venta.cantidad = Convert.ToInt32(txt_cantidad_P.Text);
                venta.id_producto = cb_producto.SelectedIndex;
                venta.tipo_pago = cb_tipopago.Text;
                venta.fecha_venta = Convert.ToDateTime(dtp_fecha.Value);
                venta.importe_venta = (Convert.ToInt32(txt_cantidad_P.Text) * logProductos.Instancia.buscarPrecio(cb_producto.SelectedIndex));
                logVenta.Instancia.InsertaVenta(venta);
                listarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos" + ex);
            }

        }
        private void CoreVenta_Load(object sender, EventArgs e)
        {
        }
        private void btn_mostrar_ventasP_Click(object sender, EventArgs e)
        {
            listarVentas();
        }
        private void listarVentas()
        {
            dgv_ventas.DataSource = logVenta.Instancia.ListaVentas();
            cb_producto.DataSource = logProductos.Instancia.ListarProductos();
            cb_producto.DisplayMember = "nombreProducto";
            cb_producto.ValueMember = "idProducto";
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
        private void btn_limpiar_registro_Click(object sender, EventArgs e)
        {
            cb_producto.SelectedIndex = -1;
            cb_tipopago.SelectedIndex = -1;
            txt_idventas_P.Text = "";
            txt_cantidad_P.Text = "";
        }

        private void txt_s_productoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txt_cantidad_P.Text);
            int precio = logProductos.Instancia.buscarPrecio(cb_producto.SelectedIndex);
            MessageBox.Show("El Monto total de la venta es: " + precio * cantidad);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_ventas.DataSource = logVenta.Instancia.BuscarVenta(Convert.ToInt32(txt_buscar.Text));
        }
    }
}
