using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name_commands = { "Россия", "Франция", "Китай", "Украина" };
            Commands commands = new Commands(name_commands);
            commands.PlayGame(new Beach());
            commands.PlayGame(new Fishing());
            commands.PlayGame(new Mousetrap());
            commands.PlayGame(new Postmen());
            commands.PlayGame(new Sea());
            commands.PlayGame(new Slide());
            commands.PlayGame(new MyGame());
            Console.ReadKey();
        }
    }
}
