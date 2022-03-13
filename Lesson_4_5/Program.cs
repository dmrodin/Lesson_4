using System;

namespace Lesson_4_5
{
    internal class Program
    {
        static int Min, Max, Modulo;
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите B: ");
            int b = int.Parse(Console.ReadLine());       

            Program obj = new Program();

            obj.FindMinMax(a, b);
            obj.CalculateDivisor();

            Console.WriteLine(Modulo);
        }

        private void CalculateDivisor()
        {
            int modulo = Max % Min;
            if (modulo != 0)
            {
                FindMinMax(Min, modulo);
                Modulo = modulo;
                CalculateDivisor();
            }
        }

        private void FindMinMax(int a, int b)
        {
            if (a < b)
            {
                Min = a;
                Max = b;
            }
            else
            {
                Min = b;
                Max = a;
            }
        }

    }
}
