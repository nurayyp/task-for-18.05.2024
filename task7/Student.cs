namespace task7
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }
        public Student(string name, string surname, int year)
        {
            Name = name;
            Surname = surname;
            Year = year;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Surname} {Year}");
        }
    }
}
