using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class _05_SerialAndParallel
    {
        public async void FactorialAsync()
        {
            //serial
            await Task.Run(()=>Factorial(4));
            await Task.Run(() => Factorial(3));
            await Task.Run(() => Factorial(5));
            //parralel
            Task t1 = Task.Run(() => Factorial(10));
            Task t2 = Task.Run(() => Factorial(9));
            Task t3 = Task.Run(() => Factorial(8));
            await Task.WhenAll(new[] { t1, t2, t3 });
        }
        static void Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {result}");
        }
    }
}
