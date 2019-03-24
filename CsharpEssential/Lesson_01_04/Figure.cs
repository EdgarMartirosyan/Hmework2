using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_04
{
    class Figure
    {

        Point[] point;

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public void PrimetrCalculator()
        {
            double sum = 0;
            for (int i = 0; i < point.Length - 1; i++)
            {
                sum += LengthSide(point[i], point[i + 1]);
            }
            Console.WriteLine(sum += LengthSide(point[point.Length - 1], point[0]));
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            point = new Point[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
        }
    }
}
