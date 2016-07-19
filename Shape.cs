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
        public int MaxX
        {
            get
            {
                return Points.Max(x => x.X);
            }
        }
        public int MaxY
        {
            get
            {
                return Points.Max(x => x.Y);
            }
        }
        public int MinX
        {
            get
            {
                return Points.Min(x => x.X);
            }
        }
        public int MinY
        {
            get
            {
                return Points.Min(x => x.Y);
            }
        }

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
 
        public bool ContainsPoint(Point point)
        {
            return Points.Contains(point);
        }

        public bool ContainsPoint(int x, int y)
        {
            return Points.Contains(new Point(x,y));
        }
    }
}
