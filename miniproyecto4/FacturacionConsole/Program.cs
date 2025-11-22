using BibliotecaDescuentos;
using BibliotecaDescuentos.Discounts;
using BibliotecaDescuentos.Models;

Console.WriteLine("=== SISTEMA DE FACTURACIÓN ===");

Console.Write("Ingrese nombre del cliente: ");
string name = Console.ReadLine();

Console.WriteLine("Tipo de cliente:");
Console.WriteLine("1. Regular");
Console.WriteLine("2. Silver");
Console.WriteLine("3. Gold");
Console.WriteLine("4. VIP");

Console.Write("Seleccione: ");
int option = int.Parse(Console.ReadLine());

var type = option switch
{
    1 => CustomerType.Regular,
    2 => CustomerType.Silver,
    3 => CustomerType.Gold,
    4 => CustomerType.VIP,
    
};

var customer = new Customer(name, type);

Console.Write("Ingrese subtotal: ");// se ingresa el subtotal de la factura a realizar
decimal subtotal = decimal.Parse(Console.ReadLine());

// en esta area se registra los descuentos dispinibles
var discounts = new List<IDiscount>()
{
    new NoDiscount(),
    new TieredDiscount()           // se aplica el descuento por niveles
};

var manager = new DiscountManager(discounts);

var result = manager.GetBestDiscount(subtotal, customer);

Console.WriteLine($"\nDescuento aplicado: {result.discount.Name}");
Console.WriteLine($"Monto descontado: Q{result.amount}");
Console.WriteLine($"Total a pagar: Q{subtotal - result.amount}");

// aqui se guarda cuando realizamos una factura
File.AppendAllText("facturas.txt",
    $"{DateTime.Now} | {customer.Name} | {customer.Type} | Subtotal: {subtotal} | Desc: {result.amount} | Total: {subtotal - result.amount}\n");

Console.WriteLine("\nFactura guardada en facturas.txt");
