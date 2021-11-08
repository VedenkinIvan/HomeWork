using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число (x > 0): ");
            int x = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int f = 1;

            while (i <= x)
            {
                f = f * i;
                i++;
            }

            Console.Write($"Факториал числа {x} = {f}");

            Console.ReadKey();
        }
    }
}
