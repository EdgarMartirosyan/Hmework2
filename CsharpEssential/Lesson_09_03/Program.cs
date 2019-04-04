using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_09_03
{

    

    class Program
    {
        delegate int MyDelegate();
        delegate double MyArrayDelegate(MyDelegate[] a);

        static int GetRandom()
        {
            return new Random().Next(1,100);
        }



        static void Main(string[] args)
        {
            var array = new MyDelegate[5];
            

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom).Invoke();
            }


            MyArrayDelegate d = delegate (MyDelegate[] c)
            {
                double sr = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    sr += c[i].Invoke();
                }
                return sr / array.Length;
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Invoke() + " ");
            }
            Random rar = new Random();

          

            Console.WriteLine("\n mijin tvabanakany {0:##.###}", d(array));
            Console.WriteLine(rar.Next(1, 100));
            //Delay
            Console.ReadKey();

        }
    }
}
