using Microsoft.VisualStudio.TestTools.UnitTesting;
using BicycleRental.Entities;


namespace BicycleRental.Test
{

    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void RentDayProgramWithMoreTreeBicycles()
        {
            Rental Rental = new Rental {
                                        BicycleCount = 4,
                                        };
            var result = Rental.RentBicycle("d", 4);
            Assert.AreEqual(224, Rental.TotalPrice);
        }

        [TestMethod]
        public void RentDayProgramWithOneBicycle()
        {
            Rental Rental = new Rental
            {
                BicycleCount = 1,
            };
            var result = Rental.RentBicycle("d", 4);
            Assert.AreEqual(80, Rental.TotalPrice);
        }


        [TestMethod]
        public void RentHoursProgramWithOneBicycle()
        {
            Rental Rental = new Rental
            {
                BicycleCount = 1,
            };
            var result = Rental.RentBicycle("h", 6);
            Assert.AreEqual(30, Rental.TotalPrice);
        }

        [TestMethod]
        public void RentWeekProgramWithOneBicycle()
        {
            Rental Rental = new Rental
            {
                BicycleCount = 1,
            };
            var result = Rental.RentBicycle("w", 2);
            Assert.AreEqual(120, Rental.TotalPrice);

        }

        [TestMethod]
        public void ApllydiscountPercetageOneBicle()
        {
            Discounts discount = new Discounts();
            var result = discount.ApplyDiscount(1);
            Assert.AreEqual(0, result.Percentage);
            Assert.AreEqual(TypeDiscount.None, result.TypeDiscount);
        }

        [TestMethod]
        public void ApllydiscountPercetageTreeBicle()
        {
            Discounts discount = new Discounts();
            var result = discount.ApplyDiscount(4);
            Assert.AreEqual(0.30, result.Percentage);
            Assert.AreEqual(TypeDiscount.Family, result.TypeDiscount);
        }

        [TestMethod]
        public void ChoiceOfTimeUnitDay()
        {
            TimeRent time = new TimeRent();
            var result = time.CalculateTime("D");
            Assert.AreEqual(20, result.Prices.PriceChoise);
        }

        [TestMethod]
        public void ChoiceOfTimeUnitHour()
        {
            TimeRent time = new TimeRent();
            var result = time.CalculateTime("H");
            Assert.AreEqual(5, result.Prices.PriceChoise);
        }

        [TestMethod]
        public void ChoiceOfTimeUnitWeek()
        {
            TimeRent time = new TimeRent();
            var result = time.CalculateTime("W");
            Assert.AreEqual(60, result.Prices.PriceChoise);
        }
    }
}
