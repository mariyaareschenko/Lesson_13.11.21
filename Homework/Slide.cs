using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Slide : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Горка*");
            Console.WriteLine($"Команда '{commands[1]}' быстрее всех прошла испытание");
        }
    }
}
