using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13._11._21
{
    interface ICipher
    {
        string Encoding(string text, int k);
        string Decoding(string text, int k);
    }
}
