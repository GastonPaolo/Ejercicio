namespace BicycleRental.Entities
{
    public class Discounts
    {
        public TypeDiscount TypeDiscount { get; set; }
        public double Percentage { get; set; }

        public Discounts ApplyDiscount(int bycicle)
        {
            if (bycicle >= 3)
            {
                return new Discounts
                {
                    TypeDiscount = TypeDiscount.Family,
                    Percentage = 0.30
                };
            }
            else
            {
                return new Discounts
                {
                    TypeDiscount = TypeDiscount.None,
                    Percentage = 1
                };
            }
        }
    }
}
