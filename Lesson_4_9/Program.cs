using System;

namespace Lesson_4_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 12; i <= n; i++)
            {
                int amountDigit = 1;
                int tmp = i;

                while (tmp / 10 > 0)
                {
                    amountDigit++;
                    tmp /= 10;
                }

                int sumOdd = 0;
                int sumEven = 0;
                tmp = i;
                
                for (int j = amountDigit; j > 0; j--) 
                {
                    int digit = tmp % 10;
                    if (j % 2 == 0) sumEven += digit;
                    else sumOdd += digit;

                    tmp /= 10;
                }

                if (sumEven > sumOdd) Console.WriteLine(i);
            }
        }
    }
}
