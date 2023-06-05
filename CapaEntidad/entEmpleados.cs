using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleados
    {
        public int idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string apellidoEmpleado { get; set; }
        public string direccionEmpleado { get; set; }
        public string telefonoEmpleado { get; set; }
        public string emailEmpleado { get; set; }
        public char sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
