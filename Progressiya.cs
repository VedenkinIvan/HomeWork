using System;

namespace Progressiya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во членов арифметической прогрессии: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Сумма первых {n} членов прогрессии = {sum}");

            Console.ReadKey();
        }
    }
}
