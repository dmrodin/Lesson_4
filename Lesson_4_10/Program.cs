using System;

namespace Lesson_4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите Y: ");
            int y = int.Parse(Console.ReadLine());

            bool elementFound = false;

            while (!elementFound && x > 0)
            {
                int digitX = x % 10;

                while(y > 0)
                {
                    int digitY = y % 10;

                    if (digitX == digitY)
                    {
                        elementFound = true;
                        break;
                    }

                    y /= 10;
                }

                x /= 10;
            }

            if (elementFound) Console.WriteLine("ДА");
            else Console.WriteLine("НЕТ");

        }
    }
}
