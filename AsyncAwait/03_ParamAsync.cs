using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class _03_ParamAsync
    {
        public void DoubleMain()
        {
            FactorialAsync(5);
            FactorialAsync(6);
            Console.WriteLine($"Некоторая работа");
        }

        static async void FactorialAsync(int n)
        {
           int x = await Task.Run(() =>Factorial(n));
            Console.WriteLine($"Факториал {n} равен {x}");
        }
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
            //Thread.Sleep(5000);
            //Console.WriteLine($"Факториал равен {result}");
        }
    }
}
