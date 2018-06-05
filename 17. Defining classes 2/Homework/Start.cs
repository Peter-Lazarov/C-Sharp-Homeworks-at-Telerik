using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Start
    {
        static void Main()
        {
            ////01.
            //var vhod = new Point3D();
            //vhod.x = 5.1;
            //vhod.y = 2.0;
            //vhod.z = -3.71;
            //Console.WriteLine(vhod.ToString());
            //Console.WriteLine(vhod.pointO());

            //var darvo = new Point3D();
            //darvo.x = 1;
            //darvo.y = 1;
            //darvo.z = 1;

            //var znak = new Point3D();
            //znak.x = 2;
            //znak.y = 1;
            //znak.z = 1;

            //var chupka1 = new Point3D();
            //chupka1.x = 3;
            //chupka1.y = 5;
            //chupka1.z = 6;

            //var chupka2 = new Point3D();
            //chupka2.x = 4;
            //chupka2.y = 7;
            //chupka2.z = 8;

            //Console.WriteLine(darvo.ToString());
            //Console.WriteLine(znak.ToString());

            //double resultat = Distance.Calc(darvo, znak);
            //Console.WriteLine(resultat);

            ////Save region
            //var patechka = new Path();
            //patechka.AddPoint(darvo);
            //patechka.AddPoint(znak);

            //var reka = new Path();
            //reka.AddPoint(chupka1);
            //reka.AddPoint(chupka2);

            //PathStorage.Save(patechka, "proba.txt");
            //PathStorage.Save(reka, "proba.txt");

            ////Load region
            //List<Path> nova = PathStorage.Load("coordinates.txt");

            //Console.WriteLine(nova[0].ToString());
            //Console.WriteLine();
            //Console.WriteLine(nova[1].ToString());
            //Console.WriteLine();
            //Console.WriteLine(nova[2].ToString());
            //Console.WriteLine();
            //Console.WriteLine(nova[3].ToString());
            
            Matrix<int> square = new Matrix<int>(2,2);
            square.ElementSet(0, 0, 2);
            square.ElementSet(0, 1, 3);
            square.ElementSet(1, 0, 4);
            square.ElementSet(1, 1, 5);
            
            Matrix<int> square2 = new Matrix<int>(2, 2);

            square2.ElementSet(0, 0, 2);
            square2.ElementSet(0, 1, 4);
            square2.ElementSet(1, 0, 2);
            square2.ElementSet(1, 1, 6);

            //Problem 10. Matrix operations
            Matrix<int> multy = new Matrix<int>(2, 2);
            multy = square * square2;

            var ver = typeof(Point3D).GetCustomAttributes(false);
            //Problem 11. Version attribute
            foreach (var item in ver)
            {
                var att = (VersionAttribute)item;
                Console.WriteLine(att.ToString());
            }
        }
    }
}
