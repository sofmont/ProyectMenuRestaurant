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
            int opcion;
            double total = 0;
            List<string> pedido = new List<string>();

            do
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
                        pedido.Add("Hamburguesa - $80");
                        total += 80;
                        break;
                    case 2:
                        pedido.Add("Pizza - $120");
                        total += 120;
                        break;
                    case 3:
                        pedido.Add("Tacos - $60");
                        total += 60;
                        break;
                    case 4:
                        pedido.Add("Refresco - $25");
                        total += 25;
                        break;
                    case 5:
                        Console.WriteLine("\nFinalizando pedido...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nProducto agregado al pedido.");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);

            Console.Clear();
            Console.WriteLine(" RESUMEN DE TU PEDIDO ");
            Console.WriteLine("-------------------------");

            foreach (string item in pedido)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine($"TOTAL A PAGAR: ${total}");
            Console.WriteLine("\n¡Gracias por tu compra!");
            Console.ReadKey();
        }
    }
}

