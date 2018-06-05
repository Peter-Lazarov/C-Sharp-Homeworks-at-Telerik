using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    using Classes;
    class Program
    {
        static void Main()
        {
            //First test
            //Rectangle matrakcho = new Rectangle(5, 7);
            //Console.WriteLine(matrakcho.CalculateSurface());

            //Triangle rabcho = new Triangle(4,6);
            //Console.WriteLine(rabcho.CalculateSurface());

            //Square ploshtadcho = new Square(4);
            //Console.WriteLine(ploshtadcho.CalculateSurface());

            //Secound test
            Rectangle matrakcho = new Rectangle(5, 7);
            Triangle rabcho = new Triangle(4, 6);
            Square ploshtadcho = new Square(4);
            Triangle vrahcho = new Triangle(6, 8);

            foreach (var item in Shapes.AllShapes)
            {
                Console.WriteLine("{0} have surface with area {1}", item.GetType().Name, item.CalculateSurface());
            }
        }
    }
}
