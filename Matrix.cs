using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Shape_Detection
{
    public class Matrix<T>
    {

        public Matrix()
        {
            Points = new List<List<T>>();
        }

        public Matrix(List<List<T>> data)
        {
            Points = data;
        }

        public List<List<T>> Points { get; private set; }

        public int Length
        {
            get
            {
                return Points.Count;
            }
        }

        public T[] this[int y]
        {
            get
            {
                return GetRowAt(y);
            }
        }

        public T this[Point point]
        {
            get
            {
                return GetItemAt(point);
            }
        }


        public T[] GetRowAt(int y)
        {
            return Points[y].ToArray();
        }

        public T GetItemAt(int x, int y)
        {
            return Points[y][x];
        }

        public T GetItemAt(Point point)
        {
            return Points[point.Y][point.X];
        }

        public T[][] GetAsArray()
        {
            return Points.Select(Enumerable.ToArray).ToArray();
        }

        public void AddRow(T[] row)
        {
            Points.Add(new List<T>(row));
        }

        public void AddRows(T[][] rows)
        {
            for(int i = 0; i < rows.Length; i++)
            {
                Points.Add(new List<T>(rows[i]));
            }
        }

        public void InsertRow(int index, T[] row)
        {
            Points.Insert(index, new List<T>(row));
        }

        public void RemoveRow(int index)
        {
            Points.RemoveAt(index);
        }

        public void ChangeRow(int index, T[] row)
        {
            Points[index] = new List<T>(row);
        }

        public void SetItem(int x, int y, T value)
        {
            Points[y][x] = value;
        }
    }
}
