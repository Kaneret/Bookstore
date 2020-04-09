using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Core
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Money Price { get; set; } = new Money();
    }
}
