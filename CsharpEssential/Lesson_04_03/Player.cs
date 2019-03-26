using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_03
{
    class Player:IPlayable,IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play music");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause playing");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stope playing");
        }
        public void Record()
        {
            Console.WriteLine("Record music");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause recording");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stope recording");
        }

    }
}
