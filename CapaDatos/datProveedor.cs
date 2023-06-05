using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        #region listado
        ////////////////////listado de Proveedores
        public List<entProveedor> ListaProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Pro = new entProveedor();
                    Pro.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                    Pro.rucProveedor = dr["rucProveedor"].ToString();
                    Pro.NomProveedor = dr["NomProveedor"].ToString();
                    Pro.ApeProveedor = dr["ApeProveedor"].ToString();
                    Pro.TipoProducto = dr["TipoProducto"].ToString();
                    Pro.direccionProveedor = dr["direccionProveedor"].ToString();
                    Pro.igvProveedor = dr["igvProveedor"].ToString();
                    Pro.telefonoProveedor = dr["telefonoProveedor"].ToString();
                    Pro.emailProveedor = dr["emailProveedor"].ToString();
                    Pro.fechaProveedor = Convert.ToDateTime(dr["fechaProveedor"]);
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
        #endregion listado
       
        #region insertar
        public Boolean InsertaProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rucProveedor", Pro.rucProveedor);
                cmd.Parameters.AddWithValue("@NomProveedor", Pro.NomProveedor);
                cmd.Parameters.AddWithValue("@ApeProveedor", Pro.ApeProveedor);
                cmd.Parameters.AddWithValue("@TipoProducto", Pro.TipoProducto);
                cmd.Parameters.AddWithValue("@direccionProveedor", Pro.direccionProveedor);
                cmd.Parameters.AddWithValue("@igvProveedor", Pro.igvProveedor);
                cmd.Parameters.AddWithValue("@telefonoProveedor", Pro.telefonoProveedor);
                cmd.Parameters.AddWithValue("@emailProveedor", Pro.emailProveedor);
                cmd.Parameters.AddWithValue("@fechaProveedor", Pro.fechaProveedor);
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
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        #endregion insertar
        
        #region editar
        public Boolean EditaProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", Pro.idProveedor);
                cmd.Parameters.AddWithValue("@rucProveedor", Pro.rucProveedor);
                cmd.Parameters.AddWithValue("@NomProveedor", Pro.NomProveedor);
                cmd.Parameters.AddWithValue("@ApeProveedor", Pro.TipoProducto);
                cmd.Parameters.AddWithValue("@TipoProducto", Pro.TipoProducto);
                cmd.Parameters.AddWithValue("@direccionProveedor", Pro.direccionProveedor);
                cmd.Parameters.AddWithValue("@igvProveedor", Pro.igvProveedor);
                cmd.Parameters.AddWithValue("@telefonoProveedor", Pro.telefonoProveedor);
                cmd.Parameters.AddWithValue("@emailProveedor", Pro.emailProveedor);
                cmd.Parameters.AddWithValue("@fechaProveedor", Pro.fechaProveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        #endregion editar

        #region eliminar
        public Boolean EliminarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", Pro.idProveedor);
                cmd.Parameters.AddWithValue("@rucProveedor", Pro.rucProveedor);
                cmd.Parameters.AddWithValue("@NomProveedor", Pro.NomProveedor);
                cmd.Parameters.AddWithValue("@ApeProveedor", Pro.ApeProveedor);
                cmd.Parameters.AddWithValue("@TipoProducto", Pro.TipoProducto);
                cmd.Parameters.AddWithValue("@direccionProveedor", Pro.direccionProveedor);
                cmd.Parameters.AddWithValue("@igvProveedor", Pro.igvProveedor);
                cmd.Parameters.AddWithValue("@telefonoProveedor", Pro.telefonoProveedor);
                cmd.Parameters.AddWithValue("@emailProveedor", Pro.emailProveedor);
                cmd.Parameters.AddWithValue("@fechaProveedor", Pro.fechaProveedor);
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