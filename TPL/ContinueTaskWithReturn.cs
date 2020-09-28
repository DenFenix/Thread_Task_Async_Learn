using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class ContinueTaskWithReturn
    {
        public void DoubleMain()
        {
            Task<int> tk = new Task<int>(() => Sum(4, 5));
            Task tk2 = tk.ContinueWith(sum => Display(sum.Result));
            tk.Start();
            tk2.Wait();
            Task tk3 = tk2.ContinueWith((Task t) => 
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });
            Task tk4 = tk3.ContinueWith((Task t) =>
            {
                Console.WriteLine($"Id текущей задачи {Task.CurrentId}");
            });
            Console.WriteLine("End of Main");
            Console.ReadLine();


        }

        private static int Sum(int v1, int v2) => v1 + v2;

        static void Display(int sum)
        {
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
