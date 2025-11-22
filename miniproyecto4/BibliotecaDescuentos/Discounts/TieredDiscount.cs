using BibliotecaDescuentos.Models;

namespace BibliotecaDescuentos.Discounts
{
    public class TieredDiscount : IDiscount
    {
        public string Name => "Descuento por tipo de cliente";

        public decimal Calculate(decimal subtotal, Customer customer)
        {
            return customer.Type switch
            {
                CustomerType.Silver => subtotal * 0.05m,
                CustomerType.Gold   => subtotal * 0.10m,
                CustomerType.VIP    => subtotal * 0.20m,
                _ => 0
            };
        }
    }
}

