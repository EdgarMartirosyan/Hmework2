using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_03
{
    enum Post
    {
        masnagetA=160,
        avagMasnagetB=150,
        bazhniPetC=149,
        varchutyanPetD=153,
        tnoren=151

    }
    class Accauntant
    {
        public  bool  AskForBonus (Post worker,int hours)
        {
            if ((int)worker >= hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nermucel premia stanalu hamar minimal amsakan zhamaqanaky");
            int hours = Convert.ToInt32(Console.ReadLine());
            Accauntant hashvark = new Accauntant();

            if (hashvark.AskForBonus(Post.avagMasnagetB, hours))
            {
                Console.WriteLine("Give bonus");
            }
            else
            {
                Console.WriteLine("Don't give bonus");
            }
            
               
        }
    }
}
