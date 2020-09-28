using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class _04_ReturnAsync
    {
        //void
        public async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }

        //Task
        public async Task FactorialAsync2(int n)
        {
            await Task.Run(() => Factorial(n));
        }

        //Task<T>
        public async Task<int> FactorialAsync3(int n)
        {
            //return await Task.Run(() => Factorial(n));
            return await Task.Run(() => Factorial2(n));
        }

        //ValueTask<T>
        public async ValueTask<int> FactorialAsync4(int n)
        {
            return await Task.Run(() => Factorial2(n));
        }


        private static void Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал равен {result}");
        }

        private static int Factorial2(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
