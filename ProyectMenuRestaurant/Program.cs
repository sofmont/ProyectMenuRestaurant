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
            Console.WriteLine("BIENVENIDO A MEX & CO");
            Console.Write("Ingresa tu nombre");
            string nombre = Console.ReadLine();
            Cliente cliente = new Cliente(nombre);
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
                    case 1: // Hamburguesas
                        Console.WriteLine(" MENU DE HAMBURGUESAS");
                        Console.WriteLine("1. Sencilla - $70");
                        Console.WriteLine("2. Doble - $90");
                        Console.WriteLine("3. Especial - $110");
                        Console.Write("Elige tu hamburguesa: ");

                        int h = int.Parse(Console.ReadLine());

                        switch (h)
                        {
                            case 1: cliente.AgregarAlTotal(70); break;
                            case 2: cliente.AgregarAlTotal(90); break;
                            case 3: cliente.AgregarAlTotal(110); break;
                            default: Console.WriteLine("Opcion no valida"); break;
                        }
                        break;

                    case 2: // Pizzas
                        Console.WriteLine("MENU DE PIZZAS");
                        Console.WriteLine("1. Pepperoni - $120");
                        Console.WriteLine("2. Boneless - $140");
                        Console.WriteLine("3. Suprema - $150");
                        Console.Write("Elige tu pizza: ");

                        int p = int.Parse(Console.ReadLine());

                        switch (p)
                        {
                            case 1: cliente.AgregarAlTotal(120); break;
                            case 2: cliente.AgregarAlTotal(140); break;
                            case 3: cliente.AgregarAlTotal(150); break;
                            default: Console.WriteLine("Opcion no valida"); break;
                        }
                        break;

                    case 3: // Tacos
                        Console.WriteLine("MENU DE TACOS");
                        Console.WriteLine("1. Orden de Asada - $120");
                        Console.WriteLine("2. Orden de Pastor - $120");
                        Console.WriteLine("3. Orden de Barbacoa - $110");
                        Console.Write("Elige tu taco: ");

                        int t = int.Parse(Console.ReadLine());

                        switch (t)
                        {
                            case 1: cliente.AgregarAlTotal(120); break;
                            case 2: cliente.AgregarAlTotal(120); break;
                            case 3: cliente.AgregarAlTotal(110); break;
                            default: Console.WriteLine("Opcion no valida"); break;
                        }
                        break;

                    case 4: // Bebidas
                        Console.WriteLine("MENU DE BEBIDAS");
                        Console.WriteLine("1. CocaCola - $30");
                        Console.WriteLine("2. Agua - $15");
                        Console.WriteLine("3. Sprite - $25");
                        Console.WriteLine("4. Jugo - $20");
                        Console.WriteLine("5. Pepsi - $30");
                        Console.Write("Elige tu bebida: ");

                        int b = int.Parse(Console.ReadLine());

                        switch (b)
                        {
                            case 1: cliente.AgregarAlTotal(70); break;
                            case 2: cliente.AgregarAlTotal(90); break;
                            case 3: cliente.AgregarAlTotal(110); break;
                            case 4: cliente.AgregarAlTotal(70); break;
                            case 5: cliente.AgregarAlTotal(90); break;
                            default: Console.WriteLine("Opcion no valida"); break;
                        }
                        break;
                }

                Console.WriteLine("\nTotal actual: $" + cliente.Total);
                Console.WriteLine("------------------------\n");
            }
            Console.Clear();
            Console.WriteLine("cliente:" + cliente.Nombre);
            Console.WriteLine("TOTAL A PAGAR: $" + cliente.Total);
            Console.WriteLine("MEX & CO Te da las gracias por tu compra");
            Console.ReadKey();
        }
    }
}
