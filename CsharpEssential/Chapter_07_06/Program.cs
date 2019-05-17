using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5,8,2,19,19,19,100,101,107, 28,12,12,1,3,95 };
            int count = 1;
            int max = 0;
            int chek = 0;
            
           

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    
                    if (array[i]<array[j] && array[j]>chek)
                    {
                      // int[] trans = { array[i]};
                           count++;
                    }
                    if (array[j] > chek)
                    {
                        chek = array[j];
                    }

                }
                chek = 0;
                if (count > max)
                {
                    max = count;
                }
                count = 1;
            }

            
            Console.WriteLine(max);

            Console.WriteLine(new string('-',30));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
