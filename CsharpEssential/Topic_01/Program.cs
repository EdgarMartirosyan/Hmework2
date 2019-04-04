using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_01
{
    class Program
    {
        static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] >= array[i])
                    {
                        int a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
        }

        static int Count(int n)
        {
            int k;
            for (k = 0; n > 0; k++)
            {
                n /= 10;
            }
            return k;
        }

        static int[] GetArray(int length, int number)
        {
            int[] arrayOne = new int[length];

            for (int i = 0; number > 0; number /= 10)
            {
                arrayOne[i] = number % 10;
                i++;
            }
            return arrayOne;
        }
        static int GetNumber(int[] array)
        {          
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                a = array[i] * (int)Math.Pow(10, array.Length - i - 1) + a;              
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nermucel arajin tivy");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nermucel erkrord tivy");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int length1 = Count(number1);
            int length2 = Count(number2);
            if (length1 == length2)
            {

                int[] arrayOne = GetArray(length1, number1);
                int[] arrayTwo = GetArray(length2, number2);

                Sort(arrayOne);
                Sort(arrayTwo);
                if (GetNumber(arrayOne)/ GetNumber(arrayTwo)==1)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
                
               
            }
            else
            {
                Console.WriteLine("mutqagrvac tiveri nisheri qanaky arden isk chen hamapatasxanum");
            }
        }
    }
}
