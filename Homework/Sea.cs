using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Sea : IGame
    {
        public void Play(string [] commands)
        {
            Console.WriteLine("Игра *Море*");
            Console.WriteLine($"Команда '{commands[3]}'дольше всех продержалась под водой");
        }
    }
}
