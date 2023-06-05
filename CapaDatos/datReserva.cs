using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class datReserva
    {
        #region sigleton

        private static readonly datReserva _instancia = new datReserva();

        public static datReserva Instancia
        {
            get
            {
                return datReserva._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Reserva

        public List<entReserva> ListarReserva()
        {
            SqlCommand cmd = null;
            List<entReserva> lista = new List<entReserva>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entReserva Cli = new entReserva();
                    Cli.idReserva = Convert.ToInt32(dr["idReserva"]);
                    Cli.fecha = Convert.ToDateTime(dr["fecha"]); ;
                    Cli.idClientes = Convert.ToInt32(dr["idClientes"]);
                    Cli.idProducto = Convert.ToInt32(dr["idProducto"]);
                    Cli.estReserva = Convert.ToBoolean(dr["estReserva"]);
                    lista.Add(Cli);
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
        //InsertarReserva
        public Boolean InsertarReserva(entReserva Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReserva", Cli.idReserva);
                cmd.Parameters.AddWithValue("@fecha", Cli.fecha);
                cmd.Parameters.AddWithValue("@idClientes", Cli.idClientes);
                cmd.Parameters.AddWithValue("@idProducto", Cli.idProducto);
                cmd.Parameters.AddWithValue("@estReserva", Cli.estReserva);
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

        public Boolean EditarReserva(entReserva Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReserva", Cli.idReserva);
                cmd.Parameters.AddWithValue("@fecha", Cli.fecha);
                cmd.Parameters.AddWithValue("@idClientes", Cli.idClientes);
                cmd.Parameters.AddWithValue("@idProducto", Cli.idProducto);
                cmd.Parameters.AddWithValue("@estReserva", Cli.estReserva);
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
        public Boolean EliminarReserva(entReserva Man)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReserva", Man.idReserva);
                cmd.Parameters.AddWithValue("@fecha", Man.fecha);
                cmd.Parameters.AddWithValue("@idClientes", Man.idClientes);
                cmd.Parameters.AddWithValue("@idProducto", Man.idProducto);
                cmd.Parameters.AddWithValue("@estReserva", Man.estReserva);

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
        public DataTable BuscarReserva(int id)
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("pa_buscarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReserva", id);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return dt;
        }
        #endregion metodos
    }
}
