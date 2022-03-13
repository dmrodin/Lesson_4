using System;

namespace Lesson_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());

            int counter = 0;

            for(int i = 1; Math.Sqrt(i) < a; i++) counter++;

            Console.WriteLine(counter);
        }
    }
}
