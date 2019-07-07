using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        public static  bool IsMatchh(string s, string p)
        {

            int count = 0;


            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = 0; j < p.Length - 1; j++)
                {
                    if (p[j] == s[i] && (p[j + 1] == s[i + 1] || p[j + 1] == '*' || p[j + 1] == '.'))
                    {
                        count++;
                        break;
                    }
                    if ((p[j] == '*' || p[j] == '.') && p[j + 1] == s[i + 1])
                    {
                        count++;
                        break;
                    }
                    if ((p[j] == '*' || p[j] == '.') && (p[j + 1] == s[i + 1] || p[j + 1] == '*' || p[j + 1] == '.'))
                    {
                        count++;
                        break;
                    }


                }

            }

            if (s.Length - 1 == count)

                return true;
            return false;

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(IsMatchh( "edgar", "asd*e.g.r*as"));

            Console.ReadKey();
        }
    }
}
