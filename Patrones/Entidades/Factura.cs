using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Entidades
{
    using System;
    using System.Collections.Generic;

    public class Factura
    {
        public int FacturaId { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<Producto> Productos { get; set; }
        public decimal Total { get; set; }

        public Factura(int facturaId, List<Producto> productos)
        {
            FacturaId = facturaId;
            FechaEmision = DateTime.Now;
            Productos = productos;
            Total = CalcularTotal();
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var producto in Productos)
            {
                total += producto.Precio * producto.Stock;
            }
            return total;
        }
    }

}
