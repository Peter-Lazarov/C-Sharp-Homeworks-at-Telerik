using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework
{
    public class PathStorage
    {
        static bool onceRead = true;
        static bool onceWrite = true;

        public static void Save(Path PathtoAdd, string fileName)
        {
            if (onceWrite)
            {
                Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
                onceWrite = false;
            }
            StreamWriter Pathbuilder = new StreamWriter(fileName, append: true);
            foreach (var item in PathtoAdd.Trajectory)
            {
                Pathbuilder.WriteLine(item.ToString());
            }
            Pathbuilder.WriteLine();
            Pathbuilder.Close();
        }
        public static List<Path> Load(string coordfile)
        {
            if (onceRead)
            {
                Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
                onceRead = false;
            }
            List<Path> allPaths = new List<Path>();
            StreamReader Pathreader = new StreamReader(coordfile);
            string line = Pathreader.ReadLine();
            double[] coord = new double[3];
            Point3D readed = new Point3D();

            while (line != null)
            {
                Path loaded = new Path();
                while ((line != null) && (line != ""))
                {
                    coord = line.Split(' ').Select(double.Parse).ToArray();
                    readed.x = coord[0];
                    readed.y = coord[1];
                    readed.z = coord[2];
                    loaded.Trajectory.Add(readed);
                    line = Pathreader.ReadLine();
                }
                allPaths.Add(loaded);
                line = Pathreader.ReadLine();
            }
            
            Pathreader.Close();
            return allPaths;
        }
    }
}
