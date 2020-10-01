using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1Tests
{
    [TestClass()]
    public class BikeTests
    {
        private readonly Bike _bike = new Bike();
        [TestMethod()]
        public void IdTest()
        {
            _bike.Id = 4;
            Assert.AreEqual(4,_bike.Id);

            _bike.Id = 0;
            Assert.AreEqual(0,_bike.Id);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bike.Id = -1);
        }

        [TestMethod()]
        public void ColorTest()
        {
            _bike.Color = "Red";
            Assert.AreEqual("Red", _bike.Color);

            _bike.Color = "Yellow";
            Assert.AreEqual("Yellow",_bike.Color);

            Assert.ThrowsException<ArgumentNullException>(() => _bike.Color = null);
        }

        [TestMethod]
        public void PriceTest()
        {
            _bike.Price = 60;
            Assert.AreEqual(60, _bike.Price);

            _bike.Price = 0;
            Assert.AreEqual(0,_bike.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bike.Price = -1);
        }

        [TestMethod]
        public void GearTest()
        {
            _bike.Gear = 4;
            Assert.AreEqual(4,_bike.Gear);

            _bike.Gear = 30;
            Assert.AreEqual(30,_bike.Gear);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bike.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bike.Gear = 33);
        }
    }
}