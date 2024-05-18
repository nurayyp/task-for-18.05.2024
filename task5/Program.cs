using task5;

public static class Program
{
    public static void Main()
    {
        Electronic electronic = new Electronic("Iphone", 2000, "Titan");
        Clothes clothes = new Clothes("D&G", 500, "XL");
        Order order = new Order();
        order.AddProduct(electronic);
        order.AddProduct(clothes);
        order.GetProductsDetails();
    }
}