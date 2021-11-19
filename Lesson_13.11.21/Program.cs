using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13._11._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1");
            ACipher aCipher = new ACipher();
            int k = 1;
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string ciphertext = aCipher.Encoding(text, k);
            string decryptedtext = aCipher.Decoding(ciphertext, k);
            Console.WriteLine($"Зашифрованный текст в классе ACipher: {ciphertext}");

            BCipher bCipher = new BCipher();
            ciphertext = bCipher.Encoding(text, k);
            decryptedtext = bCipher.Decoding(ciphertext, k);
            Console.WriteLine($"Этот же текст, зашифрованный в классе BCipher: {ciphertext}");
            Console.WriteLine($"Расшифрованный текст: {decryptedtext}");

            Console.WriteLine("Домашнее задание 10.1");
            Circle circle = new Circle(5);
            Console.WriteLine("Enter shape color");
            string color = Console.ReadLine();
            circle.ChangeColor(color);
            circle.Status();
            Console.WriteLine("Want to move the shape?");
            string answer = Console.ReadLine().ToLower();
            if (answer.Equals("yes"))
            {
                Console.WriteLine("Enter coordinates and displacement");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int num = int.Parse(Console.ReadLine());
                circle.Movement(x, y, num);
            }
            else
            {
                Console.WriteLine($"Square: {circle.Square()}");
            }
            circle.Print();

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine("Enter shape color");
            color = Console.ReadLine();
            rectangle.ChangeColor(color);
            Console.WriteLine($"Rectangle square: {rectangle.Square()}");
            rectangle.Print();
            Console.ReadKey();
        }
    }
}
