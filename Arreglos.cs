using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETMOD1041221
{
    class Arreglos
    {
        public static void Main()
        {            
            double[] notas= new double[] { 0, 0, 0 };
            double sumaNotas = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(string.Format("Ingrese nota {0}",(i+1)));
                notas[i] = double.Parse(Console.ReadLine());
                sumaNotas += notas[i];
            }
            Console.WriteLine("Imprimir valores ingresados");

            foreach (var item in notas)
            {
                Console.WriteLine(string.Format("valor:{0} ",item));
            }
            Console.WriteLine(string.Format("la nota promedio es:{0:0.00}",(sumaNotas/ notas.Length)));

            Console.ReadLine();
        }

    }
}
