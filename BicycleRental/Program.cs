using System;
using BicycleRental.Entities;

namespace BicycleRental
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args[0] == "-h")
            {
                Console.WriteLine("Ingrese las siguientes Opciones para Correr el Programa");
                Console.WriteLine("Ejemplo: h 3 30");
                Console.WriteLine("primer parametro: h es para Horas");
                Console.WriteLine("segundo parametro: Cantidad de Tiempo");
                Console.WriteLine("Tercer  parametro: Cantidad de Bicis");
                Console.WriteLine("------------");
                Console.WriteLine("Parametro de tiempo pueden ser:");
                Console.WriteLine("h");
                Console.WriteLine("d");
                Console.WriteLine("w");
            }
            else
            {
                var time = Convert.ToInt32(args[0]);
                var identify = args[1];
                var bicycle = Convert.ToInt32(args[2]);

                Rental BicycleRental = new Rental
                {
                    BicycleCount = bicycle
                };

                BicycleRental.RentBicycle(identify, time);

                Console.WriteLine("Usted ha Alquilado: " + bicycle + " bicicletas");
                Console.WriteLine("-----------------");
                Console.WriteLine("Total de Precio a pagar: $" + BicycleRental.TotalPrice);
                Console.WriteLine("-----------------");
            }
        }
    }
}
