using System;
using System.Collections.Generic;
using System.Data.Entity;
using Bookstore.Domain.Core;

namespace Bookstore.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
