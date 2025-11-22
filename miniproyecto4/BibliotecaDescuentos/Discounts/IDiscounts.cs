using BibliotecaDescuentos.Models;

namespace BibliotecaDescuentos.Discounts
{
    public interface IDiscount
    {
        decimal Calculate(decimal subtotal, Customer customer);
        string Name { get; }
    }
}
