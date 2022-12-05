using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите желаемое число: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    break;
                Console.Write("Ошибка: ");
            }
            while (true);
            t_1(n, 0);
        }
        static void t_1(int nmax, int n)
        {
            int j;

            if (n <= nmax)
            {
                for (j = 1; j <= n; j++)
                    Console.Write(n + " ");
                Console.WriteLine();
                t_1(nmax, n + 1);
            }
        }
    }
}