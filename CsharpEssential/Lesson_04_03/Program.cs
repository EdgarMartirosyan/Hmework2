using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPlayable playable = new Player();
            //playable.Play();
            //playable.Stop();
            //IRecodable recodable = new Player();
            //recodable.Record();



            Player player = new Player();
            player.Play();
            player.Record();
            (player as IPlayable).Stop();
            (player as IRecodable).Stop();

            Console.ReadKey();

        }
    }
}
