namespace task2
{
    public class Cat : Animal
    {
        public Cat(string name, string color, int age, string breed) : base(name, color, age, breed)
        {
            
        }
        public override string MakeVoice()
        {
            return "miaw";
        }
    }
}
