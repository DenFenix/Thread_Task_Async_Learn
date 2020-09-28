using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class SubTask
    {
        public void DoubleMain()
        {
            Task outer = Task.Factory.StartNew(() => 
            {
                Console.WriteLine("Outer task starting...");
                var inner = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Inner task starting...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inner task finished...");
                });
                
            }, TaskCreationOptions.AttachedToParent);// чтобы вложенная задача выполнялась вместе с внешней
            outer.Wait(); //ожидаем выполнение внешней задачи
            Console.WriteLine("End of Main");
        }
    }
}
