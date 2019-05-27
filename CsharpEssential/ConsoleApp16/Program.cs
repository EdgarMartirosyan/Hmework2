using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "edg";
            string p = "ed*";
            string ard;
           
            bool chek = false;
            int count = 0;


            for (int i = 0; i < s.Length-1; i++)
            {
                for (int j = 0; j < p.Length-1; j++)
                {
                    if ((p[j]==s[i] && p[j+1]==s[i+1])|| p[j]=='*')
                    {
                        count++;
                    }
                }
                
            }
            if (s.Length-1==count)
            {
                chek = true;
            }


          


           /* for (int i = 0; i < s.Length-1; i++)
            {
                for (int j = 0; j < p.Length-1; i++)
                {
                    if (p[j] == s[i]&&(p[j+1]== s[i + 1] || p[j+1]=='*'|| p[j+i]=='.')||p[j]=='*'||p[i]=='.')
                    {

                        count++;
                    }
                    if (s.Length == count)
                    {
                        chek = true;
                    }
                }
               
            }*/
            Console.WriteLine(chek);
            Console.ReadKey();
        }
    }
}
