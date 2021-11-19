using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Beach : IGame
    {
        public void Play(string [] commands)
        {
            Console.WriteLine("Игра *Пляж*");
            Console.WriteLine($"Команда '{commands[0]}' добралась первой");

        }
    }
}
