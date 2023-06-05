using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int idProveedor { get; set; }
        public string rucProveedor { get; set; }
        public string NomProveedor { get; set; }
        public string ApeProveedor { get; set; }
        public string TipoProducto { get; set; }
        public string direccionProveedor { get; set; }
        public string igvProveedor { get; set; }
        public string telefonoProveedor { get; set; }
        public string emailProveedor { get; set; }
        public DateTime fechaProveedor { get; set; }
    }
}
