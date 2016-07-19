using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Shape_Detection
{
    public class DetectShape
    {
        public DetectShape(Matrix<int> matrix, int valueToFind)
        {
            this.matrix = matrix;
            value = valueToFind;
            Print2DArray(matrix.GetAsArray());
            ParseTable();
        }

        Matrix<int> matrix;
        int value;

        public void ParseTable()
        {
            var firstCorner = false;
            var nonEmptyPoints = new List<Point>();
            for(int y = 0; y < matrix.Length; y++)
            {
                for(int x = 0; x < matrix[y].Length; x++)
                {
                    if (IsValue(matrix[y][x]))
                    {
                        if (!firstCorner)
                        {
                            firstCorner = true;

                        }
                        Console.WriteLine("Session");
                        List<Point> points = new List<Point>();
                        FindShapes(x, y, points);
                        PrintListOfPoints(points);
                    }
                }
            }
            
        }

        public void FindShapes(int x, int y, List<Point> points)
        {
            if(x < 0 || y < 0 || y >= matrix.Length || x >= matrix[y].Length)
            {
                return;
            }

            if(IsValue(matrix[y][x]))
            {
                matrix.SetItem(x, y, 0);
                points.Add(new Point(x, y));

                FindShapes(x, y - 1, points);
                FindShapes(x, y + 1, points);
                FindShapes(x - 1, y, points);
                FindShapes(x + 1, y, points);
            }
            return;
        }


        public bool IsValue(int item)
        {
            return item == value;
        }

        public void PrintListOfPoints(List<Point> points)
        {
            foreach(Point point in points)
            {
                Console.WriteLine(point);
            }
        }

        public void Print2DArray(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
