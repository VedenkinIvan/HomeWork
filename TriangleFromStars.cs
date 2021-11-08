using System;

namespace TriangleFromStars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину катета: ");
            int m = Convert.ToInt32(Console.ReadLine());
            string s = "";
            for (int i = 0; i < m; i++)
            {
                s += "*";
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
