﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13._11._21
{
    class Rectangle : Point
    {
        private int len1;
        private int len2;
        public Rectangle(int len1, int len2)
        {
            this.len1 = len1;
            this.len2 = len2;
        }
        public override double Square()
        {
            return len1 * len2;
        }
    }
}
