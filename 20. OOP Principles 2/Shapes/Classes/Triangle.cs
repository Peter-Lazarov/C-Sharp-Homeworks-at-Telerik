using System;

namespace Classes
{
    public class Triangle : Shapes
    {
        public Triangle(double sideWidth, double Height) : base(sideWidth, Height)
        {
        }
        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }
    }
}
