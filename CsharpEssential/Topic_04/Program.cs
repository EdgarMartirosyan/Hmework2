using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "WWWWBWWWWWBBBWWWWWWWWWWB";
            string text1 = null;
            int count = 1;
            for (int i = 0; i < text.Length ; i++)
            {
                try
                {
                    if (text[i] == text[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        if (count!=1)
                        {
                            text1 = text1 + count.ToString() + text[i];
                        }
                        else
                        {
                            text1 = text1  + text[i];
                        }
                        count = 1;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("aaaaaaaaaaaaaaaaaa");
                }
            }

            Console.WriteLine(text1);
            string text2 = null;
            

            for (int i = 0; i < text1.Length; i++)
            {
               
                try
                {
                    if ( text1[i]/ 1 > 0)
                    {
                        for (int j = 0; j < text1[i]; j++)
                        {
                            text2 = text2 + text1[i + 1];
                        }
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("bbbbbbbbbbbbbbb");
                }
                
            }
            Console.WriteLine(text2);

            string a = "1";
            string b = "5";
            int c = int.Parse(a)/1;
            Console.WriteLine(c);


            Console.ReadKey();
        }
    }
}
