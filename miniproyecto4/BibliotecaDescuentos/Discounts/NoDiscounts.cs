using BibliotecaDescuentos.Models;

namespace BibliotecaDescuentos.Discounts
{
    public class NoDiscount : IDiscount
    {
        public string Name => "Sin descuento";

        public decimal Calculate(decimal subtotal, Customer customer)
        {
            return 0m;
        }
    }
}

