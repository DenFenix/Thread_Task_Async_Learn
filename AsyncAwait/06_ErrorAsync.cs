using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class _06_ErrorAsync
    {

        public async void FactorialAsync(int n)
        {
            Task task = null;
            try
            {
                task = Task.Run(() => Factorial(n));
                await task;

            }
            catch(Exception)
            {
                Console.WriteLine(task.Exception.InnerException.Message);
                // ошибка,  IsFaulted =true
                Console.WriteLine($"{task.IsFaulted}");
            }
        }

        public async void FactorialAsync2(int n)
        {
            try
            {
                await Task.Run(() => Factorial(n)); 
            }
            catch(Exception ex)
            {
                await Task.Run(() => Console.WriteLine(ex.Message));
            }
            finally
            {
                await Task.Run(() => Console.WriteLine("finalyAwayt"));
            }
        }

        public async Task DoMultipleAsync()
        {
            Task allTask = null;
            try
            {
                Task task1 = Task.Run(() => Factorial(-1));
                Task task2 = Task.Run(() => Factorial(-2));
                Task task3 = Task.Run(()=>Factorial(-3));
                Task task4 = Task.Run(() => Factorial(4));
                allTask = Task.WhenAll(task1, task2, task3, task4);
                await allTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Исключение: " + ex.Message);
                Console.WriteLine("IsFaulted: " + allTask.IsFaulted);
                foreach (var inx in allTask.Exception.InnerExceptions)
                {
                    Console.WriteLine("Внутреннее исключение: " + inx.Message);
                }
            }
        }

        static void Factorial(int n)
        {
            if (n < 1)
                throw new Exception($"{n}: число не должно быть меньше 1");
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {result}");
        }
    }
}
