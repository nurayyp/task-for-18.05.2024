namespace task3
{
    public class Square : Shape
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Side = side;
        }
        public override double FindArea()
        {
            return Side * Side;
        }
    }
}
