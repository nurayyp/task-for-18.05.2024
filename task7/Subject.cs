namespace task7
{
    internal class Topic
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Topic(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Duration}");
        }
    }
}
