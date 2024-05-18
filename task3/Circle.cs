namespace task3
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double FindArea()
        {
            return Math.Round(Radius * Radius * 2 * Math.PI);
        }
    }
}
