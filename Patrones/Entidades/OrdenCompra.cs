using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Entidades
{
    using System;
    using System.Collections.Generic;

    public class OrdenCompra
    {
        public int OrdenId { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<Producto> Productos { get; set; }
        public DateTime FechaOrden { get; set; }

        public OrdenCompra(int ordenId, Proveedor proveedor)
        {
            OrdenId = ordenId;
            Proveedor = proveedor;
            Productos = new List<Producto>();
            FechaOrden = DateTime.Now;
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }
    }

}
