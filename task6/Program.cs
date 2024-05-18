using task6;

public static class Program
{ 
    public static void Main()
    {
        Invoice inv = new Invoice("678904", "Alex", "Foxtrot");
        inv.Article = "USB-hab";
        inv.Quantity = 6;
        inv.Price = 30;
        inv.CostCalculation(true);
        Console.WriteLine($"{inv.GetDetails()} - {inv.CostCalculation(true)}");
    }
}
