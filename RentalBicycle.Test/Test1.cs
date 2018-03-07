using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
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
            Assert.AreEqual(33, Rental.TotalPrice);
        }

        [TestMethod]
        public void RentProgramWithOneBicycle()
        {
            Rental Rental = new Rental
            {
                BicycleCount = 1,
            };
            var result = Rental.RentBicycle("d", 4);
            Assert.AreEqual(33, Rental.TotalPrice);
        }

        [TestMethod]
        public void Apllydiscount()
        {

        }

        [TestMethod]
        public void PriceFill()
        {

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
