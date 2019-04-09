using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 11, 12, 13, 14, 20, 60, 90, 100, 102, 105, 114, 41026 };
            int x = 14;
            int left = 0;
            int right = array.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                if (x > array[right] || x < array[left])
                {
                    Console.WriteLine("No");
                    break;
                }

                mid = (left + right) / 2;

                if (array[mid] > x)
                {
                    right = mid - 1;
                }

                else if (array[mid] < x)
                {
                    left = mid + 1;
                }

                else if (array[mid] == x)

                {
                    Console.WriteLine("yes");
                    break;
                }

                if (array[mid] != x)

                    Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
