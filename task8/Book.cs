namespace task8
{
    public class Book 
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public Book( string name, string author, int pages) 
        {
            Name = name;
            Author = author;
            Pages = pages;
        }
        public void GetDetails()
        {
            Console.WriteLine($" {Name} {Author} {Pages}");
        }
    }
}
