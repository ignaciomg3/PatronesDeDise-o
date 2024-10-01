using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Cliente(int clienteId, string nombre, string direccion)
        {
            ClienteId = clienteId;
            Nombre = nombre;
            Direccion = direccion;
        }
    }

}
