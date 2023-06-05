using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProveedor _instancia = new logProveedor();
        //privado para evitar la instanciación directa
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton

        #region Listado

        public List<entProveedor> ListaProveedor()
        {
            return datProveedor.Instancia.ListaProveedor();
        }

        #endregion Listado


        public void InsertaProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.InsertaProveedor(Pro);
        }
        public void EditaProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.EditaProveedor(Pro);
        }
        public void EliminarProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.EliminarProveedor(Pro);
        }
    }
}
