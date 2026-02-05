using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectMenuRestaurant
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public double Total { get; private set; }

        public Cliente(string nombre)
        {
            Nombre = nombre;
            Total = 0;
        }

        public void AgregarAlTotal(double monto)
        {
            Total += monto;
        }

        public void MostrarTotal()
        {
            Console.WriteLine("Cliente: " + Nombre);
            Console.WriteLine("TOTAL A PAGAR: $" + Total);
        }
    }
}
