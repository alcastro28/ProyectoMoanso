using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logProductos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProductos _instancia = new logProductos();
        //privado para evitar la instanciación directa
        public static logProductos Instancia
        {
            get
            {
                return logProductos._instancia;
            }
        }
        #endregion singleton
        public void InsertaProductos(entProductos Pro)
        {
            datProductos.Instancia.InsertaProductos(Pro);
        }
        public void EliminaProductos(entProductos Pro)
        {
            datProductos.Instancia.EliminaProducto(Pro);
        }
        public List<entProductos> ListarProductos()
        {
            return datProductos.Instancia.ListaProductos();
        }
        public int buscarPrecio(int id)
        {
            return datProductos.Instancia.busquedaPrecio(id);
        }
    }
}