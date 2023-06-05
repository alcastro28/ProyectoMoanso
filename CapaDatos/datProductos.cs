using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datProductos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProductos _instancia = new datProductos();
        //privado para evitar la instanciación directa
        public static datProductos Instancia
        {
            get
            {
                return datProductos._instancia;
            }
        }
        #endregion singleton

        #region listado
        ////////////////////listado de Proveedores
        public List<entProductos> ListaProductos()
        {
            SqlCommand cmd = null;
            List<entProductos> lista = new List<entProductos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProductos Pro = new entProductos();
                    Pro.idProducto = Convert.ToInt32(dr["idProducto"]);
                    Pro.nombreProducto = dr["nombreProducto"].ToString();
                    Pro.stockProducto = Convert.ToInt32(dr["stockProducto"]);
                    Pro.precioPro = Convert.ToInt32(dr["precioPro"]);
                    lista.Add(Pro);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public int busquedaPrecio(int id)
        {
            SqlCommand cmd = null;
            int precio = -1;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("pa_buscarPrecio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                precio = Convert.ToInt32(dr["precioPro"]);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return precio;
        }

        #endregion listado

        #region inserta
        public Boolean InsertaProductos(entProductos Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreProducto", Pro.nombreProducto);
                cmd.Parameters.AddWithValue("@stockProducto", Pro.stockProducto);
                cmd.Parameters.AddWithValue("@precioPro", Pro.precioPro);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }
        #endregion inserta

        #region eliminar
        public Boolean EliminaProducto(entProductos Pro)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", Pro.idProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", Pro.nombreProducto);
                cmd.Parameters.AddWithValue("@stockProducto", Pro.stockProducto);
                cmd.Parameters.AddWithValue("@precioPro", Pro.precioPro);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
        #endregion eliminar
    }
}
