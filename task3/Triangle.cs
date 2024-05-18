namespace task3
{
    public class Triangle : Shape
    {
        public int Side { get; set; }
        public int Height { get; set; }
        public Triangle(int side, int height) 
        {
            Height = height;
            Side = side;
        }
        public override double FindArea()
        {
            return (Height * Side)/2;
        }
    }
}
