using Bookstore.Domain.Core;

namespace Bookstore.Services
{
    public interface IOrder
    {
        void MakeOrder(Book book);
    }
}
