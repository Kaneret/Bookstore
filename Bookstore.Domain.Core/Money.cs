
namespace Bookstore.Domain.Core
{
    public class Money
    {
        public decimal Amount { get; set; }

        public Money Apply(Discount discount)
        {
            var amount = Amount * (1 - discount.Value);
            return new Money()
            {
                Amount = amount
            };
        }
    }
}
