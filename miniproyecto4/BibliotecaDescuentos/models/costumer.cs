namespace BibliotecaDescuentos.Models
{
    public class Costomer
    {
        public string Name { get; set; }
        public string Type { get; set; } 

        public Costomer(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
