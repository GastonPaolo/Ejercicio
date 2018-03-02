using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRental.Entities
{
    public class Discounts
    {
        public TypeDiscount TypeDiscount { get; set; }
        public int Percentage { get; set; }

        public Discounts ApplyDiscount()
        {
            return new Discounts
                {
                    TypeDiscount = TypeDiscount.Family,
                    Percentage = 30
            };
        }
    }
}
