using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETMOD1041221
{
    class Restaurante
    {
        public static void Main()
        {
            #region If anidados con for          
            //Console.WriteLine("Sistema de restaurante");
            //Console.WriteLine("Ingrese el numero de iteraciones a realizar");
            //int iteracion = int.Parse(Console.ReadLine());
            //if (iteracion < 1)
            //{
            //    Console.WriteLine("No es valido..");
            //}
            //else
            //{
            //    for (int i = 0; i < iteracion; i++)
            //    {
            //        Console.WriteLine("Esta abierto el restaurante?");
            //        Console.WriteLine("1- Abierto");
            //        Console.WriteLine("2- Cerrado");
            //        int estRes = int.Parse(Console.ReadLine());
            //        if (estRes == 1)
            //        {
            //            Console.WriteLine("Hay mesa disponible?");
            //            Console.WriteLine("1- Si");
            //            Console.WriteLine("2- No");
            //            int mesaDisponible = int.Parse(Console.ReadLine());
            //            if (mesaDisponible == 1)
            //            {
            //                Console.WriteLine("Hay mariscos en menu?");
            //                Console.WriteLine("1- Si");
            //                Console.WriteLine("2- No");
            //                int mariscos = int.Parse(Console.ReadLine());
            //                if (mariscos == 1)
            //                {
            //                    Console.WriteLine("Ordena mariscos !!!");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Gracias por el servicio !!!");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("En casa..");
            //            Console.WriteLine("Hay Mariscos en nevera?");
            //            Console.WriteLine("1- Si");
            //            Console.WriteLine("2- No");
            //            int mariscosCasa = int.Parse(Console.ReadLine());
            //            if (mariscosCasa == 1)
            //            {
            //                Console.WriteLine("Preparando Mariscada ....");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Se llama a HUGO!!!");
            //            }
            //        }
            //        Console.WriteLine("****************************************************");
            //    }               

            //}
            //Console.ReadLine();
            #endregion
            #region con while
            int res = 1;
            do
            {
            Console.WriteLine("Sistema de restaurante");
            Console.WriteLine("Esta abierto el restaurante?");
            Console.WriteLine("1- Abierto");
            Console.WriteLine("2- Cerrado");
            int estRes = int.Parse(Console.ReadLine());
            if (estRes == 1)
            {
                Console.WriteLine("Hay mesa disponible?");
                Console.WriteLine("1- Si");
                Console.WriteLine("2- No");
                int mesaDisponible = int.Parse(Console.ReadLine());
                if (mesaDisponible == 1)
                {
                    Console.WriteLine("Hay mariscos en menu?");
                    Console.WriteLine("1- Si");
                    Console.WriteLine("2- No");
                    int mariscos = int.Parse(Console.ReadLine());
                    if (mariscos == 1)
                    {
                        Console.WriteLine("Ordena mariscos !!!");
                    }
                    else
                    {
                        Console.WriteLine("Gracias por el servicio !!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("En casa..");
                Console.WriteLine("Hay Mariscos en nevera?");
                Console.WriteLine("1- Si");
                Console.WriteLine("2- No");
                int mariscosCasa = int.Parse(Console.ReadLine());
                if (mariscosCasa == 1)
                {
                    Console.WriteLine("Preparando Mariscada ....");
                }
                else
                {
                    Console.WriteLine("Se llama a HUGO!!!");
                }
            }
            Console.WriteLine("****************************************************");
                Console.WriteLine("Desea continuar?");
                Console.WriteLine("1- Si");
                Console.WriteLine("2- No");
                res = int.Parse(Console.ReadLine());
            } while (res==1);


            Console.ReadLine();
            #endregion
        }
    }
}
