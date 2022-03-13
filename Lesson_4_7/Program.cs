using System;

namespace Lesson_4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());

            int counter = 0;

            while (value > 0)
            {
                if (value % 10 % 2 != 0) counter++;
                value /= 10;
            } 

            Console.WriteLine(counter);
        }
    }
}
