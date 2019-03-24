using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_04
{
    class Figure
    {
        Point A;
        Point B;

        public void LengthSide(Point A, Point B)
        {
            Console.WriteLine(A.X - A.Y);
        }
    }
}
