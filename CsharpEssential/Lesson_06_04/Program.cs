using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_04
{
    static class Extend
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2,4,3,6,5,9,1,3};

            int a;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j]>=array[i])
                    {
                        a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
        }
    }
}
