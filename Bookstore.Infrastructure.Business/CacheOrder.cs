using System;
using System.Collections.Generic;
using Bookstore.Domain.Core;
using Bookstore.Services;

namespace Bookstore.Infrastructure.Business
{
    public class CacheOrder : IOrder
    {
        public void MakeOrder(Book book)
        {
            // код покупки книги при оплате наличностью
        }
    }
}
