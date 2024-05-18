namespace task4
{
    public class Truck : Vehicle
    {
        public int Load { get; set; }
        public Truck(string brand, string model, string color, int year, int load) : base (brand, model, color, year)
        {
            Load = load;
        }
        public override string GetCarDetails()
        {
            return $"{Brand} {Model} {Color} {Year} {Load} ";
        }
    }
}
