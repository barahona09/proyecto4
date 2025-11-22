using BibliotecaDescuentos.Models;

namespace BibliotecaDescuentos.Discounts
{
    public class DiscountManager
    {
        private readonly List<IDiscount> _discounts;

        public DiscountManager(List<IDiscount> discounts)
        {
            _discounts = discounts;
        }

        public (IDiscount discount, decimal amount) GetBestDiscount(decimal subtotal, Customer customer)
        {
            decimal bestAmount = 0;
            IDiscount bestDiscount = new NoDiscount();

            foreach (var d in _discounts)
            {
                decimal amount = d.Calculate(subtotal, customer);
                if (amount > bestAmount)
                {
                    bestAmount = amount;
                    bestDiscount = d;
                }
            }

            return (bestDiscount, bestAmount);
        }
    }
}

