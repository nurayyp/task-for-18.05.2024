namespace task5
{
    public class Clothes : Product
    {
        public string Size { get; set; }
        public Clothes(string name, decimal price, string size) : base(name, price)
        {
            Size = size;
        }
    public override void GetDetails()
    {
        Console.WriteLine($"Clothes - {Name} {Price} {Size}");
    }
    }
}

