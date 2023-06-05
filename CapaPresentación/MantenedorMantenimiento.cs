using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaPresentación
{
    public partial class MantenedorMantenimiento : Form
    {
        public MantenedorMantenimiento()
        {
            InitializeComponent();
            listarMantenimiento();
            LLenarComboxCliente();

        }

        public void listarMantenimiento()
        {
            dvgMantenimiento.DataSource = logMantenimiento.Instancia.ListarMantenimiento();
        }

        private void LLenarComboxCliente()
        {
            cmbIDcliente.DataSource = logCliente.Instancia.ListarCliente();

            cmbIDcliente.DisplayMember = "idClientes";
            cmbIDcliente.ValueMember = "idClientes";
        }


        private void btn_nuevo_clienteM_Click(object sender, EventArgs e)
        {
            txtIDmantenimiento.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cmbIDcliente.ResetText();

        }

      

        private void dvgMantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Mantenimiento", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dvgMantenimiento.DataSource = tabla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entMantenimiento c = new entMantenimiento();
                c.idMantenimiento = int.Parse(txtIDmantenimiento.Text.Trim());
                c.fecha = dtFecha.Value;
                c.descripcion = txtDescripcion.Text.Trim();
                c.precio = txtPrecio.Text.Trim();
                c.idClientes = cmbIDcliente.SelectedIndex;

                logMantenimiento.Instancia.InsertarMantenimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarMantenimiento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entMantenimiento c = new entMantenimiento();
                c.idMantenimiento = int.Parse(txtIDmantenimiento.Text.Trim());
                c.fecha = dtFecha.Value;
                c.descripcion = txtDescripcion.Text.Trim();
                c.precio = txtPrecio.Text.Trim();
                c.idClientes = int.Parse(Convert.ToString(cmbIDcliente.SelectedValue));

                logMantenimiento.Instancia.EditarMantenimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarMantenimiento();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            entMantenimiento Pro = new entMantenimiento();
            Pro.idMantenimiento = int.Parse(txtIDmantenimiento.Text.Trim());
            Pro.fecha = dtFecha.Value;
            Pro.descripcion = txtDescripcion.Text.Trim();
            Pro.precio = txtPrecio.Text.Trim();
            logMantenimiento.Instancia.EliminarMantenimiento(Pro);
            listarMantenimiento();
        }

        private void btnBuscarMantenimiento_Click_1(object sender, EventArgs e)
        {
            dvgMantenimiento.DataSource = logMantenimiento.Instancia.BuscarMantenimiento(Convert.ToInt32(txt_buscar.Text));
        }
    }

}
