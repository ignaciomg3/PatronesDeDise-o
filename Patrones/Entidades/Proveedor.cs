using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Entidades
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }

        public Proveedor(int id, string nombre, string contacto)
        {
            Id = id;
            Nombre = nombre;
            Contacto = contacto;
        }
    }

}
