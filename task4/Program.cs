using task4;

public static class Program
{
    public static void Main()
    {
        Car car = new Car("BMW", "M4", "Black", 2023, 4);
        Console.WriteLine(car.GetCarDetails());
        Truck truck = new Truck("Mercedes-Benz", "Arocs", "Red", 2020, 1200);
        Console.WriteLine(truck.GetCarDetails());
    }
}