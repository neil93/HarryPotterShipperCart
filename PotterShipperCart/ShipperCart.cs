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
                totalPrice += item.Amount * item.Price;
            }

            return totalPrice;
        }
    }
}
