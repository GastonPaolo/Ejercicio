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
            var price = CaluclateTime(identifyTime);
            TotalPrice = price * BicycleCount;
            TotalPrice = TotalPrice * timeNumber;
            AplyDiscount(BicycleCount);
        }

        public int CaluclateTime(string identifyTime)
        {
            var result =  TimeRent.CalculateTime(identifyTime);
            return result.Prices.PriceChoise;
        }

        private void AplyDiscount(int bicycleCount)
        {
            var discount = Discounts.ApplyDiscount(bicycleCount);
            TotalPrice =  TotalPrice - TotalPrice * discount.Percentage;
            Discounts = discount;
        }
    }
}
