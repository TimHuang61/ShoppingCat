using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class ShoppingCartCalculator
    {
        private readonly Dictionary<int, decimal> discountDic = new Dictionary<int, decimal>
        {
            {1, 1},
            {2, 0.95m},
            {3, 0.9m},
            {4, 0.8m},
            {5, 0.75m}
        };

        public decimal CalculateTotal(IEnumerable<Book> books)
        {
            var tmpBooks = books.Where(b => b.Count > 0).ToList();
            if (tmpBooks.Count == 1)
                return tmpBooks.Sum(b => b.Price * b.Count);

            if (tmpBooks.Count > 0)
            {
                var total = tmpBooks.Sum(b => b.Price) * discountDic[tmpBooks.Count];
                tmpBooks.ForEach(b => b.Count--);

                return total + CalculateTotal(tmpBooks);
            }

            return 0;
        }
    }
}