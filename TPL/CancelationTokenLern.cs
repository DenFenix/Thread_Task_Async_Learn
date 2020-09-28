using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class CancelationTokenLern
    {
        public void DoubleMain()
        {
            //Для отмены надо создать и использовать токен
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            //получаем токен
            CancellationToken token = cancellationTokenSource.Token;
            int numer = 6;
            Task task1 = new Task(() => Factorial(numer, token));
            task1.Start();

            Console.WriteLine("Введите y для отмены операции или другой символ для её продолжения: ");
            string s = Console.ReadLine();
            if (s == "y")
                //отиеняем операцию
                cancellationTokenSource.Cancel();
            Console.Read();
        }

        static void Factorial(int x, CancellationToken token)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                //с помощью токена отлавливаем завершение
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана");
                    return;
                }
                result *= i;
                Console.WriteLine($"Факториал числа {i} равен {result}");
                Thread.Sleep(5000);
            }
        }
    }
}
