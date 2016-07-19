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
            Points = new List<Point>();
        }

        public List<Point> Points { get; private set; }


        public void AddPoint(Point point, bool sort)
        {
            if (sort)
            {
                Points.Add(point);
                SortPoints();
            }
            else
            {
                Points.Add(point);
            }
        }


        public void SortPoints()
        {
            Points = Points.OrderBy(x => x.X).ThenBy(x => x.Y).ToList();
        }
    }
}
