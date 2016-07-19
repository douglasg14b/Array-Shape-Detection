using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Shape_Detection
{
    public class ShapeParser
    {
        public ShapeParser(Matrix<int> matrix, int valueToFind)
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
            var shapes = new List<Shape>();
            for(int y = 0; y < matrix.Length; y++)
            {
                for(int x = 0; x < matrix[y].Length; x++)
                {
                    if (IsValue(matrix[y][x]))
                    {
                        Shape newShape = new Shape();
                        FindShapes(x, y, newShape);
                        shapes.Add(newShape); 
                    }
                }
            }

            foreach(Shape shape in shapes)
            {
                Console.WriteLine("Shape:");
                PrintListOfPoints(shape.Points);
            }
            
        }

        /// <summary>
        /// Parses the matrix and finds each unique shape, erases the shape as it's found
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="shape"></param>
        public void FindShapes(int x, int y, Shape shape)
        {
            if(x < 0 || y < 0 || y >= matrix.Length || x >= matrix[y].Length)
            {
                return;
            }

            if(IsValue(matrix[y][x]))
            {
                matrix.SetItem(x, y, 0);
                shape.AddPoint(new Point(x, y), true);

                FindShapes(x, y - 1, shape);
                FindShapes(x, y + 1, shape);
                FindShapes(x - 1, y, shape);
                FindShapes(x + 1, y, shape);
            }
            return;
        }

        public void ParseShape(Shape shape)
        {
            int maxX = shape.Points.Max(x => x.X);
            int maxY = shape.Points.Max(x => x.Y);
            int minX = shape.Points.Min(x => x.X);
            int minY = shape.Points.Min(x => x.Y);

            //if(shape.ContainsPoint(max))

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
