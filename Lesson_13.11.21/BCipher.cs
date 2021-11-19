﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13._11._21
{
    class BCipher : ICipher
    {
        private string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string Ecode(string str, int k)
        {
            string all_alphabet = alphabet + alphabet.ToLower();
            int len_alphabet = all_alphabet.Length;
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                char simb = str[i];
                int index = all_alphabet.IndexOf(simb);
                if (index > 0)
                {
                    int index_code = all_alphabet.Length - index - 1;
                    result += all_alphabet[index_code];
                }
                else
                {
                    result += simb.ToString();
                }
            }
            return result;
        }
        public string Encoding(string text, int k)
        {
            return Ecode(text, k);
        }
        public string Decoding(string text, int k)
        {
            return Ecode(text, -k);
        }
    }
}
