using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Shapes
    {
        private double wid;
        private double hght;

        public static List<Shapes> AllShapes = new List<Shapes>();

        public double Width
        {
            get { return wid; }
            set { wid = value; }
        }
        public double Height
        {
            get { return hght; }
            set { hght = value; }
        }

        public Shapes(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            AllShapes.Add(this);
        }

        public abstract double CalculateSurface();
    }
}
