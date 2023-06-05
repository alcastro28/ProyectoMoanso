using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaEntidad
{
    public class entCliente
    {
        public int idClientes { get; set; }
        public string razonSocial { get; set; } 
        public string idTipoCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Ciudad { get; set; } 
        public Boolean estCliente { get; set; }
        public DateTime fecRegCliente { get; set; }
    }
}
