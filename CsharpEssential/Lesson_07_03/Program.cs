using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_03
{
    struct Mystruct
    {
        public string change;
    }

    class Myclass
    {
        public string change;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Myclass testClass = new Myclass();
            Mystruct testStruct = new Mystruct();

            testClass.change = "popoxvac chi";
            testStruct.change = "popoxvac chi";

            ClassTaker(testClass);
            StructTaker(testStruct);

            Console.WriteLine(testClass.change);
            Console.WriteLine(testStruct.change);

            Console.ReadKey();
        }

        static void ClassTaker(Myclass c)
        {
            c.change = "popoxvac";
        }
        static void StructTaker(Mystruct c)
        {
            c.change = "popoxvac";
        }
    }
}
