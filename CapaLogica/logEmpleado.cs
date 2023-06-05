using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logEmpleado
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEmpleado _instancia = new logEmpleado();
        //privado para evitar la instanciación directa
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entEmpleados> ListaEmpleados()
        {
            return datEmpleado.Instancia.ListaEmpleados();
        }
        public void InsertaEmpleado(entEmpleados Emp)
        {
            datEmpleado.Instancia.InsertaEmpleado(Emp);
        }
        public void EditaEmpleado(entEmpleados Emp)
        {
            datEmpleado.Instancia.EditaEmpleado(Emp);
        }
        #endregion metodos
    }
}