namespace task8
{
    public class Account : Library
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Account(string email, string password, string name, string surname, int age) : base(email, password)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void GetAccount()
        {
            Console.WriteLine($"{Email}{Password}{Name}{Surname}{Age}");
        }
    }
}
