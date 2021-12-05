using NETMOD1P2041221;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETMOD1041221
{
    class EmpleadoAsalariado:Empleado
    {
        void ImprimirDatos()
        {
            codigo = 1;
            sueldo = 1230.00;
            nombre = "";
        }
        public static void Main()
        {
            Console.WriteLine("hola desde otra clase");
            Console.ReadLine();
        }
    }
}
