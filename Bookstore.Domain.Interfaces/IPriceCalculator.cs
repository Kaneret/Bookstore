using System.Collections.Generic;
using Bookstore.Domain.Core;

namespace Bookstore.Domain.Interfaces
{
    public interface IPriceCalculator
    {
        Money WithDiscounts(Book book, IEnumerable<Discount> discounts);
    }
}
