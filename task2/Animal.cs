namespace task2
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public Animal(string name, string color,int age, string breed)
        {
            Name = name;
            Color = color;
            Age = age;
            Breed = breed;
        }
        public abstract string MakeVoice();
        
    }
}
