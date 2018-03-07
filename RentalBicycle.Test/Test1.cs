using Microsoft.VisualStudio.TestTools.UnitTesting;
using BicycleRental.Entities;


namespace RentalBicycle.Test
{

    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void RentProgramWithMoreTreeBicycles()
        {
            Rental Rental = new Rental {
                                        BicycleCount = 4,
                                        };
            var result = Rental.RentBicycle("d", 4);
            Assert.AreEqual(56, Rental.TotalPrice);
        }

        [TestMethod]
        public void RentProgramWithOneBicycle()
        {
            Rental Rental = new Rental
            {
                BicycleCount = 1,
            };
            var result = Rental.RentBicycle("d", 4);
            Assert.AreEqual(20, Rental.TotalPrice);
        }

        [TestMethod]
        public void Apllydiscount()
        {

        }

        [TestMethod]
        public void PriceFill()
        {

        }
    }
}
