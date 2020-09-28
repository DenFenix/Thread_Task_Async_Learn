using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class CancelParallel
    {
        public void DoubleMain()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            new Task(() =>
            {
                Thread.Sleep(3000);
                cancellationTokenSource.Cancel();
            }).Start();
            int lenght = 500;
            var mass = new int[lenght];
            for (int i = 1; i <= lenght; i++)
            {
                mass[i - 1] = i;
            }
            try
            {
                Parallel.ForEach<int>(new List<int>(mass) /*{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 , 11, 12, 13 , 14,15 ,16, 17 }*/, new ParallelOptions { CancellationToken = token }, Factorial);
                // или так
                //Parallel.For(1, 8, new ParallelOptions { CancellationToken = token }, Factorial);
            }
            catch(OperationCanceledException)
            {
                Console.WriteLine("Операция прервана");
            }
            finally
            {
                //cancellationTokenSource.Dispose();
            }


        }
        static void Factorial(int x)
        {
            BigInteger result = 1;
            //for (int i = 1; i <= x; i++)
            //{
            //    //
            //    result *= i;
            //}
            Console.WriteLine($"Задача ид - {Task.CurrentId}");
            result = FactTree(x);
            Console.WriteLine($"Факториал числа {x} равен {result}");
            Thread.Sleep(3000);
        }

        static BigInteger ProdTree(int l, int r)
        {
            if (l > r)
                return 1;
            if (l == r)
                return l;
            if (r - l == 1)
                return (BigInteger)l * r;
            int m = (l + r) / 2;
            return ProdTree(l, m) * ProdTree(m + 1, r);
        }

        static BigInteger FactTree(int n)
        {
            if (n < 0)
                return 0;
            if (n == 0)
                return 1;
            if (n == 1 || n == 2)
                return n;
            return ProdTree(2, n);
        }

    }
}
