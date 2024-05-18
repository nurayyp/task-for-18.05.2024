namespace task4
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, string model, string color, int year)
        {
            Brand = brand;  
            Model = model;
            Color = color;
            Year = year;
        }
        public virtual string GetCarDetails()
        {
            return $"{Brand} {Model} {Color} {Year} ";
        }
    }
}
