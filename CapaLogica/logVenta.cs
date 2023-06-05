using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logVenta
    {
        #region sigleton
        private static readonly logVenta _instancia = new logVenta();
        public static logVenta Instancia
        {
            get
            {
                return logVenta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public DataTable ListaVentas()
        {
            return datVenta.Instancia.ListaVentas();
        }

        public void InsertaVenta(entVenta e)
        {
            datVenta.Instancia.InsertaVenta(e);
        }
        public DataTable BuscarVenta(int id)
        {
            return datVenta.Instancia.BuscarVenta(id);
        }
        #endregion metodos


    }
}
