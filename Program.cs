using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectMenuRestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double total = 0;

            while (opcion != 5)
            {
                Console.Clear();
                Console.WriteLine("  BIENVENIDO A MEX & CO  ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Hamburguesa - $80");
                Console.WriteLine("2. Pizza - $120");
                Console.WriteLine("3. Tacos - $60");
                Console.WriteLine("4. Refresco - $25");
                Console.WriteLine("5. Finalizar pedido");
                Console.WriteLine("--------------------------------");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        total += 80;
                        break;
                    case 2:
                        total += 120;
                        break;
                    case 3:
                        total += 60;
                        break;
                    case 4:
                        total += 25;
                        break;
                }

                Console.WriteLine("Total actual: $" + total);
                Console.WriteLine();
            }

            Console.WriteLine("Total a pagar: $" + total);
            Console.ReadKey();
        }
    }
}

