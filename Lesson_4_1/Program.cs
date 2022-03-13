using System;

namespace Lesson_4_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());

            for(int i = a; i <= 1000; i++)
            {
                if (i % a == 0) Console.WriteLine($"{i}");
            }
        }
    }
}
