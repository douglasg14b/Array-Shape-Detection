using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Shape_Detection
{
    public class Shape
    {
        public Shape()
        {
            points = new List<Point>();
        }

        List<Point> points;

        public void AddPoint(Point point)
        {
            points.Add(point);
        }

        public void SortPoints()
        {

        }
    }
}
