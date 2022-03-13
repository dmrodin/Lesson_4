using System;

namespace Lesson_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите B: ");
            int b = int.Parse(Console.ReadLine());

            int sum = 0;

            for(int i = a; i <= b; i++)
            {
                if (i % 7 == 0) sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
