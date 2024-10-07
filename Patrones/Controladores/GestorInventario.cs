using Patrones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace Patrones.Controladores
{
    public class GestorInventario
    {
        private ExcelManager excelManager;

        public GestorInventario(string rutaArchivo)
        {
             
            excelManager = new ExcelManager(rutaArchivo);
        }

        public List<Producto> ObtenerProductos()
        {
            return excelManager.LeerProductos();
        }

        public void AgregarProducto(Producto producto)
        {
            excelManager.GuardarProducto(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            excelManager.ActualizarProducto(producto);
        }

        public Producto ObtenerProductoPorId(int id)
        {
            var productos = excelManager.LeerProductos();
            return productos.Find(p => p.Id == id);
        }
    }
}
