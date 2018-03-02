using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BicycleRental.Entities;

namespace BicycleRental
{
    class Program
    {
        static void Main(string[] args)
        {

            Rental BicycleRental = new Rental
                                            {
                                                Days = 2,
                                                BicycleCount = 4
                                            };
             BicycleRental.RentABicecle();

        
        }
    }
}
