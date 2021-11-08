using System;

namespace CountAndSumOfEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int k = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    k++;
                    sum = sum + i;
                }
            }

            Console.WriteLine($"Кол-во четных чисел = {k}");
            Console.WriteLine($"Сумма четных чисел = {sum}");

            Console.ReadKey();
        }
    }
}
