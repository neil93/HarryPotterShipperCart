using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShipperCart
{
    public class ShipperCart
    {
        public double CalcuateCartPrice(List<Book> books)
        {
            double totalPrice = 0;
            foreach (var item in books)
            {
                totalPrice += item.Amount * item.Price * GetDiscount(books.Count);
            }

            return totalPrice;
        }

        public double GetDiscount(int bookCount)
        {
            switch (bookCount)
            {
                case 1:
                    return 1;
                case 2:
                    return 0.95;
            }

            return 0;
        }
    }
}
