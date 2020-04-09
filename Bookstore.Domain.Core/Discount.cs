using System;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Domain.Core
{
    public class Discount
    {
        [Key]
        public Guid Id { get; set; }
        public decimal Value { get; set; }
    }
}
