using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Path
    {
        // Fields
        public List<Point3D> Trajectory = new List<Point3D>();

        public void AddPoint(Point3D pointnow)
        {
            Trajectory.Add(pointnow);
        }

        public int Count()
        {
            return Trajectory.Count();
        }
        public override string ToString()
        {
            StringBuilder combiner = new StringBuilder();
            combiner.Append(Trajectory[0].ToString());
            for (int i = 1; i < Trajectory.Count(); i++)
            {
                combiner.Append(Environment.NewLine);
                combiner.Append(Trajectory[i].ToString());
            }
            return combiner.ToString();
        }
    }
}
