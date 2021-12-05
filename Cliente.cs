using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETMOD1041221
{
    public class Cliente
    {
        
        public int codigo;
        public string nombre;
        public string direccion;

        public Cliente()
        {

        }

        public Cliente(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
    }
}
