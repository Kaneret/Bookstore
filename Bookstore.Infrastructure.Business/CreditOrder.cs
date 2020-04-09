using System;
using System.Collections.Generic;
using Bookstore.Domain.Core;
using Bookstore.Services;

namespace Bookstore.Infrastructure.Business
{
    public class CreditOrder : IOrder
    {
        public void MakeOrder(Book book)
        {
            // код покупки книги с помощью кредитной карты
        }
    }
}
