using BibliotecaDescuentos.Models;

namespace BibliotecaDescuentos.Discounts
{
    public class PercentageDiscount : IDiscount
    {
        public string Name => "Descuento porcentual";
        public decimal Percentage { get; set; }

        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
        }

        public decimal Calculate(decimal subtotal, Customer customer)
        {
            return subtotal * Percentage;
        }
    }
}
