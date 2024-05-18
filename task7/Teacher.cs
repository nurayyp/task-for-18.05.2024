namespace task7
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Teacher (string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
}
