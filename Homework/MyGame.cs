using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class MyGame : IGame
    {
        public void Play(string[] commands)
        {
            Console.WriteLine("Игра *Лото*");
            Console.WriteLine($"Команда '{commands[2]}' выиграла партию у команды '{commands[3]}'");
        }
    }
}
