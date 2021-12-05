using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETMOD1041221
{
    class Switch
    {
        public static void Main()
        {
            Console.WriteLine("Sistema de consulta medica");
            Console.WriteLine("Que tipo de consulta desea gestionar?");
            Console.WriteLine("1-Consulta Externa");
            Console.WriteLine("2-Consulta de Control");
            Console.WriteLine("3-Consulta de Emergencia");
            int tipoConsulta = int.Parse(Console.ReadLine());
            switch (tipoConsulta)
            {
                case 1:
                    Console.WriteLine("Selecciono consulta Externa");
                    break;
                case 2:
                    Console.WriteLine("Selecciono consulta de control");
                    break;
                case 3:
                    Console.WriteLine("Selecciono consulta de Emergencia");
                    break;
                default:
                    Console.WriteLine("No es una opcion valida...");
                    break;
            }

            Console.ReadLine();
        }
    }
}
