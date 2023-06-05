using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {

        public int id_ventas { get; set; }
        public DateTime fecha_venta { get; set; }
        public int id_producto { get; set; }
        public string tipo_pago { get; set; }
        public int cantidad { get; set; }
        public int importe_venta { get; set; }

    }
}
