using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Commands
    {
        private string [] name;
        public Commands(string [] name)
        {
            this.name = name;
        }
        public void PlayGame(IGame game)
        {
            game.Play(name);
        }
    }
}
