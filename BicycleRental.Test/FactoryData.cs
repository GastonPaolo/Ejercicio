using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BicycleRental.Entities;

namespace BicycleRental.Test
{
    public class FactoryData
    {
        public static Discounts FillDiscounts()
        {
            return new Discounts();
        }

        public static Rental FillRental()
        {
            return new Rental();
        }


    }
}
