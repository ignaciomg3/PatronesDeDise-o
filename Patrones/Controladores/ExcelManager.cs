using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using Patrones.Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Patrones.Controladores
{
    

    public class ExcelManager
    {
        private string _filePath;

        public ExcelManager(string filePath)
        {
            _filePath = filePath;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;  // Licencia para uso no comercial
        }

        public List<Producto> LeerProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (var package = new ExcelPackage(new FileInfo(_filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];  // Primera hoja
                int rows = worksheet.Dimension.Rows;

                for (int i = 2; i <= rows; i++)  // Comienza en la fila 2 (excluye encabezados)
                {
                    int id = int.Parse(worksheet.Cells[i, 1].Text);
                    string nombre = worksheet.Cells[i, 2].Text;
                    decimal precio = decimal.Parse(worksheet.Cells[i, 3].Text);
                    int stock = int.Parse(worksheet.Cells[i, 4].Text);

                    productos.Add(new Producto(id, nombre, precio, stock));
                }
            }
            return productos;
        }

        public void GuardarProducto(Producto producto)
        {
            using (var package = new ExcelPackage(new FileInfo(_filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];  // Primera hoja
                int rows = worksheet.Dimension.Rows + 1;

                worksheet.Cells[rows, 1].Value = producto.Id;
                worksheet.Cells[rows, 2].Value = producto.Nombre;
                worksheet.Cells[rows, 3].Value = producto.Precio;
                worksheet.Cells[rows, 4].Value = producto.Stock;

                package.Save();
            }
        }

        public void ActualizarProducto(Producto producto)
        {
            using (var package = new ExcelPackage(new FileInfo(_filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];  // Primera hoja
                int rows = worksheet.Dimension.Rows;

                for (int i = 2; i <= rows; i++)
                {
                    if (int.Parse(worksheet.Cells[i, 1].Text) == producto.Id)
                    {
                        worksheet.Cells[i, 2].Value = producto.Nombre;
                        worksheet.Cells[i, 3].Value = producto.Precio;
                        worksheet.Cells[i, 4].Value = producto.Stock;
                        break;
                    }
                }
                package.Save();
            }
        }
    }

}
