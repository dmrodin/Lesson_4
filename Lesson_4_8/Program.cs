using System;

namespace Lesson_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());
            int result = 0;
            int order = 1;
            int tmp = value;

            while (tmp / 10 > 0)
            {
                order *= 10;
                tmp /= 10;
            }

            while (value > 0)
            {
                result += order * (value % 10);
                order /= 10;
                value /= 10;
            }

            Console.WriteLine(result);
        }
    }
}
