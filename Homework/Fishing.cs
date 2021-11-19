using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Fishing : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Рыбалка*");
            Console.WriteLine($"Команда {commands[1]} поймала самую большую рыбу");
        }
    }
}
