using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class ContintinueTask
    {
        public void DoubleMain()
        {
            Task tk = new Task(()=> 
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}"); 
            });

            // после task1 будет задача task2.
            //задач продолжени
            Task task2 = tk.ContinueWith(Display);
            tk.Start();

            //ждёсм окончания второй задачи
            task2.Wait();
            Console.WriteLine("Выполняется работа метода Main");
            
        }
        static void Display(Task t)
        {
            Console.WriteLine($"Id задачи: {Task.CurrentId}");
            Console.WriteLine($"Id предыдущей задачи: {t.Id}");
            Thread.Sleep(3000);
        }
    }
}
