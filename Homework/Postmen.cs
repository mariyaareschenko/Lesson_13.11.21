using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Postmen : IGame
    {
        public void Play(string [] commands)
        {
            Console.WriteLine("Игра *Почтальоны*");
            Console.WriteLine($"Команда '{commands[3]}' доставила больше всех писем");
        }
    }
}
