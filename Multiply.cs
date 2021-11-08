using System;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 6; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
