using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class _01_AsyncMeth
    {
        public void DoubleMain()
        {
            FactorialAsync();
            Console.WriteLine("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа равен {n * n}");
        }
        static async void FactorialAsync()
        {
            Console.WriteLine("Начало метода FactorialAsync");
            await Task.Run(() => Factorial());
            Console.WriteLine("Конец метода FactorialAsync");
        }
        static void Factorial()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"Факториал равен {result}");
        }
    }
}
