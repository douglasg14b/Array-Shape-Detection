using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Shape_Detection
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> map = new Matrix<int>(new List<List<int>>()
            {
                new List<int>{0,0,0,0,0,0,0,0,0,0},
                new List<int>{0,1,1,1,1,1,1,1,0,0},
                new List<int>{0,1,0,0,0,0,0,1,0,0},
                new List<int>{0,1,0,1,1,1,0,1,0,0},
                new List<int>{0,1,0,1,0,1,0,1,0,0},
                new List<int>{0,1,0,1,1,1,0,1,0,0},
                new List<int>{0,1,0,0,0,0,0,1,0,0},
                new List<int>{0,1,1,1,1,1,1,1,0,0},
                new List<int>{0,0,0,0,0,0,0,0,0,0},
                new List<int>{0,0,0,0,0,0,0,0,0,0},
            });
            ShapeParser shapeDetect = new ShapeParser(map, 1);
            Console.ReadLine();
        }
    }
}
