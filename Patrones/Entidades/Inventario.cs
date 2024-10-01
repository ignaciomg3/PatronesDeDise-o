using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Patrones.Entidades
{
    
    public class Inventario
    {
        private List<Producto> productos;

        public Inventario()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public void EliminarProducto(int productoId)
        {
            productos.RemoveAll(p => p.Id == productoId);
        }

        public Producto ObtenerProducto(int productoId)
        {
            return productos.Find(p => p.Id == productoId);
        }

        public List<Producto> ObtenerTodosLosProductos()
        {
            return productos;
        }
    }

}
