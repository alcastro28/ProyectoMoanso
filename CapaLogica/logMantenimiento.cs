using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaLogica
{
    public class logMantenimiento
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMantenimiento _instancia = new logMantenimiento();
        //privado para evitar la instanciación directa
        public static logMantenimiento Instancia
        {
            get
            {
                return logMantenimiento._instancia;
            }
        }
        #endregion singleton

        #region metodos


        ///listado
        public List<entMantenimiento> ListarMantenimiento()
        {
            return datMantenimiento.Instancia.ListarMantenimiento();
        }

        public void InsertarMantenimiento(entMantenimiento e)
        {
            datMantenimiento.Instancia.InsertarMantenimiento(e);
        }
        //editar
        public void EditarMantenimiento(entMantenimiento e)
        {
            datMantenimiento.Instancia.EditarMantenimiento(e);
        }

        public DataTable BuscarMantenimiento(int id)
        {
            return datMantenimiento.Instancia.BuscarMantenimiento(id);
        }
        public void EliminarMantenimiento(entMantenimiento Man)
        {
            datMantenimiento.Instancia.EliminarMantenimiento(Man);
        }
        #endregion metodos


    }
}
