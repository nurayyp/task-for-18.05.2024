namespace task2
{
    public class Dog : Animal
    {
        public Dog(string name, string color, int age, string breed) : base(name, color, age, breed)
        {
            
        }
        public override string MakeVoice()
        {
            return "haw";
        }
    }
}
