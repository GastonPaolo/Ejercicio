using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRental.Entities
{
    public class Rental
    {
        public int BicycleCount { get; set; }
        public Price Prices { get; set; }
        public double TotalPrice { get; set; }
        public Discounts Discounts { get; set; }

        public int? Hours { get; set; }
        public int? Days { get; set; }
        public int? Weeks { get; set; }

        public Rental RentABicecle()
        {
            return null;
        }
    }
}
