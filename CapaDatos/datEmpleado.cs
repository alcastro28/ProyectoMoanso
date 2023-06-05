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
    public class datEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEmpleado _instancia = new datEmpleado();
        //privado para evitar la instanciación directa
        public static datEmpleado Instancia
        {
            get
            {
                return datEmpleado._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Empleados
        public List<entEmpleados> ListaEmpleados()
        {
            SqlCommand cmd = null;
            List<entEmpleados> lista = new List<entEmpleados>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaEmpleados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleados Emp = new entEmpleados();
                    Emp.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    Emp.nombreEmpleado = dr["nombreEmpleado"].ToString();
                    Emp.apellidoEmpleado = dr["apellidoEmpleado"].ToString();
                    Emp.direccionEmpleado = dr["direccionEmpleado"].ToString();
                    Emp.emailEmpleado = dr["emailEmpleado"].ToString();
                    Emp.telefonoEmpleado = dr["telefonoEmpleado"].ToString();
                    Emp.sexo = Convert.ToChar(dr["sexo"]);
                    Emp.fechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"]);
                    lista.Add(Emp);
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
        /////Nuevo
        public Boolean InsertaEmpleado(entEmpleados Emp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaEmpleados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEmpleado", Emp.nombreEmpleado);
                cmd.Parameters.AddWithValue("@apellidoEmpleado", Emp.apellidoEmpleado);
                cmd.Parameters.AddWithValue("@direccionEmpleado", Emp.direccionEmpleado);
                cmd.Parameters.AddWithValue("@telefonoEmpleado", Emp.telefonoEmpleado);
                cmd.Parameters.AddWithValue("@emailEmpleado", Emp.emailEmpleado);
                cmd.Parameters.AddWithValue("@sexo", Emp.sexo);
                cmd.Parameters.AddWithValue("@fechaNacimiento", Emp.fechaNacimiento);
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
        public Boolean EditaEmpleado(entEmpleados Emp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaEmpleados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", Emp.idEmpleado);
                cmd.Parameters.AddWithValue("@nombreEmpleado", Emp.nombreEmpleado);
                cmd.Parameters.AddWithValue("@apellidoEmpleado", Emp.apellidoEmpleado);
                cmd.Parameters.AddWithValue("@direccionEmpleado", Emp.direccionEmpleado);
                cmd.Parameters.AddWithValue("@telefonoEmpleado", Emp.telefonoEmpleado);
                cmd.Parameters.AddWithValue("@emailEmpleado", Emp.emailEmpleado);
                cmd.Parameters.AddWithValue("@sexo", Emp.sexo);
                cmd.Parameters.AddWithValue("@fechaNacimiento", Emp.fechaNacimiento);
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
        #endregion metodos
    }
}
