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
            var groupBooks = GroupByBooksName(books);
            double totalPrice = 0;
            foreach (var item in groupBooks)
            {
                foreach (var book in item)
                {
                    totalPrice += book.Amount * book.Price * GetDiscount(item.Count);
                    
                }
            }

            return totalPrice;

        }

        public List<List<Book>> GroupByBooksName(List<Book> books)
        {
            var bs = new List<Book>();
            foreach (var item in books)
            {
                for (int i = 0; i < item.Amount; i++)
                {
                    bs.Add(new Book() { Amount = 1, Name = item.Name, Price = item.Price });
                }
            }

            var groupBooks = new List<List<Book>>();
            List<Book> resultList =null;
            var broups = bs.GroupBy(o => o.Name);

            var booksCountGroup = broups.Select(x => x.Count())
                                                          .Distinct()
                                                          .OrderBy(c => c).ToList();
            
            foreach (var item in booksCountGroup)
            {
                resultList = new List<Book>();
                foreach (var book in broups)
                {
                    if (book.Count()>=item)
                    {
                        resultList.Add(book.Select(o => o).FirstOrDefault());
                    }
                }
                groupBooks.Add(resultList);
            }

            return groupBooks;
        }

        public double GetDiscount(int bookCount)
        {
            switch (bookCount)
            {
                case 1:
                    return 1;
                case 2:
                    return 0.95;
                case 3:
                    return 0.9;
                case 4:
                    return 0.8;
                case 5:
                    return 0.75;
            }

            return 0;
        }
    }
}
