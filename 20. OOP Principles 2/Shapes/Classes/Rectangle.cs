namespace Classes
{
    public class Rectangle : Shapes
    {
        public Rectangle(double Width, double Height) : base(Width, Height)
        {
        }
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
