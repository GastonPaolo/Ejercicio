namespace BicycleRental.Entities
{
    public class Rental
    {
        public int BicycleCount { get; set; }
        public double TotalPrice { get; set; }
        public Discounts Discounts { get; set; }
        public TimeRent TimeRent { get; set; }

        public Rental()
        {
            Discounts = new Discounts();
            TimeRent = new TimeRent();
        }

        public Rental RentBicycle(string identifyTime, int timeNumber)
        {
            CalculatePrice(identifyTime, timeNumber);
            return new Rental
            {
                TotalPrice = TotalPrice,
                Discounts = Discounts,
                BicycleCount = BicycleCount,
            };

        }

        public void CalculatePrice(string identifyTime, int timeNumber)
        {
            var price = CaluclateTime(identifyTime, timeNumber);
            TotalPrice = price * BicycleCount;
            AplyDiscount(BicycleCount);
        }

        public int CaluclateTime(string identifyTime, int timeNumber)
        {
            var result =  TimeRent.CalculateTime(identifyTime, timeNumber);
            return result.Prices.PriceChoise;
        }

        private void AplyDiscount(int bicycleCount)
        {
            Discounts.ApplyDiscount(bicycleCount);
            TotalPrice =  TotalPrice * Discounts.Percentage;
        }
    }
}
