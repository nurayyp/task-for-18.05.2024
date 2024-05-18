namespace task5
{
    public class Electronic : Product
    {
        public string Material { get; set; }
        public Electronic(string name, decimal price, string material) : base(name, price)
        {
            Material = material;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Electronic - {Name} {Price} {Material}");
        }
    }
}
