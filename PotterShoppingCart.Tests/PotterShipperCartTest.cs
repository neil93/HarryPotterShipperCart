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

        [TestMethod]
        public void 第一集買了一本_第二集也買了一本_價格應為190元()
        {
            //arrange
            var target = new ShipperCart();
            var books = new List<Book>()
            {
                new Book(){Name="HarryPotter1",Amount=1,Price=100},
                new Book(){Name="HarryPotter2",Amount=1,Price=100},
            };

            //act
            var expected = 190;
            var actual = target.CalcuateCartPrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三集各買了一本_價格應為270元()
        {
            //arrange
            var target = new ShipperCart();
            var books = new List<Book>()
            {
                new Book(){Name="HarryPotter1",Amount=1,Price=100},
                new Book(){Name="HarryPotter2",Amount=1,Price=100},
                new Book(){Name="HarryPotter3",Amount=1,Price=100},
            };

            //act
            var expected = 270;
            var actual = target.CalcuateCartPrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四集各買了一本_價格應為320元()
        {
            //arrange
            var target = new ShipperCart();
            var books = new List<Book>()
            {
                new Book(){Name="HarryPotter1",Amount=1,Price=100},
                new Book(){Name="HarryPotter2",Amount=1,Price=100},
                new Book(){Name="HarryPotter3",Amount=1,Price=100},
                new Book(){Name="HarryPotter4",Amount=1,Price=100},
            };

            //act
            var expected = 320;
            var actual = target.CalcuateCartPrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一次買了整套_一二三四五集各買了一本_價格應為375元()
        {
            //arrange
            var target = new ShipperCart();
            var books = new List<Book>()
            {
                new Book(){Name="HarryPotter1",Amount=1,Price=100},
                new Book(){Name="HarryPotter2",Amount=1,Price=100},
                new Book(){Name="HarryPotter3",Amount=1,Price=100},
                new Book(){Name="HarryPotter4",Amount=1,Price=100},
                new Book(){Name="HarryPotter5",Amount=1,Price=100},
            };

            //act
            var expected = 375;
            var actual = target.CalcuateCartPrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
