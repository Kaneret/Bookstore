using System.Collections.Generic;
using System.Linq;
using Bookstore.Domain.Core;
using Bookstore.Domain.Interfaces;

namespace Bookstore.Services
{
    public sealed class PriceCalculator : IPriceCalculator
    {
        public Money WithDiscounts(Book book, IEnumerable<Discount> discounts)
        {
            return discounts.Aggregate(book.Price, (m, d) => m.Apply(d));
        }
    }
}
