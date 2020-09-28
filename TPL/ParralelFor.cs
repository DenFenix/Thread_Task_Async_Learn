using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class ParralelFor
    {
        public void DoubleMain()
        {
            ParallelLoopResult result1 =  Parallel.For(1, 10, Factorial);
            Task.WaitAll();
            Console.WriteLine("Поток Main");
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 }, Factorial);
            Task.WaitAll();
            if(!result1.IsCompleted)
            {
                Console.WriteLine($"Выполнение цикла завершено на итерации {result.LowestBreakIteration}");
            }
        }
        

        static void Factorial(int x, ParallelLoopState pls)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
                if (i == 5)
                    pls.Break();
            }
            Console.WriteLine($"выполняется задача {Task.CurrentId}");
            Console.WriteLine($"Факториал числа {x} равен {result}");
            Thread.Sleep(3000);
        }
    }

   
}
