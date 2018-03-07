namespace BicycleRental.Entities
{
    public class TimeRent
    {
        public string IdentifyTime { get; set; }
        public Price Prices { get; set; }

        public TimeRent()
        {
            Prices = new Price();
        }

        public TimeRent CalculateTime (string identifyTime)
        {
            TimeRent timeRent = new TimeRent
                                        {
                                            IdentifyTime = identifyTime,
                                            Prices = new Price()
                                        };
            switch (identifyTime.ToLower())
            {
                case "h":
                    timeRent.Prices.PriceChoise = Prices.Hour;
                    break;
                case "d":
                    timeRent.Prices.PriceChoise = Prices.Day;
                    break;
                case "w":
                    timeRent.Prices.PriceChoise = Prices.Week;
                    break;

            }
            return timeRent;
        }
    }
}
