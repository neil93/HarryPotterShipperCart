using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShipperCart;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShipperCartTest
    {
        [TestMethod]
        public void 第一集買了一本_其他都沒買_價格應為100元()
        {
            //arrange
            var target = new ShipperCart();
            var books = new List<Book>()
            {
                new Book(){Name="HarryPotter1",Amount=1,Price=100},
            };

            //act
            var expected = 100;
            var actual = target.CalcuateCartPrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
