using System;

namespace Lesson_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());

            int maxDivisor = 1;

            if (a % 2 == 0) Console.WriteLine(a / 2);
            else
            {
                for (int i = 1; i < a / 2; i++)
                {
                    if(a % i == 0) maxDivisor = i;
                }

                Console.WriteLine(maxDivisor);
            }
        }
    }
}
