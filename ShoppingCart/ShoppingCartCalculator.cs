using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ShoppingCartCalculator
    {
        public decimal CalculateTotal(IEnumerable<Book> books)
        {
            var tmpBooks = books.Where(b => b.Count > 0).ToList();
            if (tmpBooks.Count > 0)
            {
                var total = tmpBooks.Sum(b => b.Price) * GetDiscount(tmpBooks.Count);
                tmpBooks.ForEach(b => b.Count--);

                return total + CalculateTotal(tmpBooks);
            }

            return 0;
        }

        private decimal GetDiscount(int count)
        {
            switch (count)
            {
                case 2:
                    return 0.95m;
                case 3:
                    return 0.9m;
                case 4:
                    return 0.8m;
                case 5:
                    return 0.75m;
                default:
                    return 1;
            }
        }
    }
}
