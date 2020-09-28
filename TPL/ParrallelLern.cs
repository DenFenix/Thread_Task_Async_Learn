using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class ParrallelLern
    {
        public void DoubleMain()
        {
            //позволяет парралельное выполнение задачь
            Parallel.Invoke(Display,
                () =>
                {
                    Console.WriteLine($"Выполненная задача {Task.CurrentId}");
                },
                () => Factorial(5));
        }

        private static void Factorial(int v)
        {
            int result = 1;
            for(int i = 1; i <=v; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Thread.Sleep(3000);
            Console.WriteLine($"Рехультат {result}");
        }

        static void Display()
        {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Thread.Sleep(3000);
        }
    }
}
