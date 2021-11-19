using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13._11._21
{
    public enum Condition { visible, invisible }
    public enum Color { red, green, blue, yellow}
    class Figure : IFigure
    {
        private Color color;
        private Condition condition;
        public Color ChangeColor(string str)
        {
            if (str.Equals("red"))
            {
                color = Color.yellow;
            }
            else if (str.Equals("green"))
            {
                color = Color.blue;
            }
            else if (str.Equals("blue"))
            {
                color = Color.red;
            }
            else
            {
                color = Color.green;
            }
            return color;
        }
        public Condition Status()
        {
            Console.WriteLine("Is the figure visible?");
            string answer = Console.ReadLine();
            if (answer.Equals("yes"))
            {
                condition = Condition.visible;
            }
            else
            {
                condition = Condition.invisible;
            }
            return condition;
        }
        public void Movement(int x, int y, int num)
        {
            x += num;
            y += num;
            Console.WriteLine($"The figure has shifted. It is coordinates: ({x}, {y})");
        }
        public void Print()
        {
            Console.WriteLine($"Figure color: {color}");
            Console.WriteLine($"Figure condition: {condition}");
        }
    }
}
