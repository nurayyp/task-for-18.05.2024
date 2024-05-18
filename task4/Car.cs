namespace task4
{
    public class Car : Vehicle
    {
        public int Passenger { get; set; }
        public Car(string brand, string model, string color, int year, int passenger) : base(brand, model, color, year)
        {
            Passenger = passenger;
        }
        public override string GetCarDetails()
        {
            return $"{Brand} {Model} {Color} {Year} {Passenger} ";
        }
    }
}
