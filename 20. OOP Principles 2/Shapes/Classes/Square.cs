namespace Classes
{
    public class Square : Shapes
    {
        public Square(double Width) : base(Width, Width)
        {
        }
        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }
    }
}
