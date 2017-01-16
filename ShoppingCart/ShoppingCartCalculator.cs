using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ShoppingCartCalculator
    {
        public decimal CalculateTotal(IEnumerable<Book> books)
        {
            if (books.Count() > 3)
            {
                return books.Sum(b => b.Price * b.Count) * 0.8m;
            }

            if (books.Count() > 2)
            {
                return books.Sum(b => b.Price * b.Count) * 0.9m;
            }

            if (books.Count() > 1)
            {
                return books.Sum(b => b.Price * b.Count) * 0.95m;
            }

            return books.Sum(b => 100 * b.Count);
        }
    }
}
