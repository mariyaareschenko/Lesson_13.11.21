using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13._11._21
{
    class Circle : Point
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Square()
        {
            return Math.PI * radius * radius;
        }
    }
}
