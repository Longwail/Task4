using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task9Console
{
    class Program
    {

        static int A(int n)
        {
            if (n == 1) return 1;
            else if (n > 1)
            {
                int a = n;
                if ((Math.Pow(2, a - 1) <= n) && (n <= Math.Pow(2, a)))
                {
                    return a;
                }
                return A(n / 2) + 1;
            }
            return 0;
        }
        static void Main(string[] args)
        {

            int n;
            while (true)
            {
                try
                {
                    Console.Write("Введите n: ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("n не может быть нулём или отрицателтным числом");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            Console.WriteLine("a = " + A(n));
        }
    }
}