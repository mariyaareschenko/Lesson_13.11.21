using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Mousetrap : IGame
    {
        public void Play(string [] commands)
        {
            Console.WriteLine("Игра *Мышеловка*");
            Console.WriteLine($"Команда '{commands[2]}' поймала мышь");
        }
    }
}
