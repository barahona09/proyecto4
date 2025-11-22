namespace BibliotecaDescuentos.Models
{
    public enum CustomerType { Regular, Silver, Gold, VIP }

    public class Customer
    {
        public Customer(string? name, CustomerType type)
        {
            Name = name;
            Type = type;
        }

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "";
        public CustomerType Type { get; set; } = CustomerType.Regular;
        public int LoyaltyPoints { get; set; }
    }
}

