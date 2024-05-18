using task2;

public static class Program
{
    public static void Main()
    {
        Cat cat = new Cat("mestan", "boz", 2, "sotland");
        Console.WriteLine(cat.MakeVoice());
        Dog dog = new Dog("spark", "ag-qara", 3, "husky");
        Console.WriteLine(dog.MakeVoice());
    }
}