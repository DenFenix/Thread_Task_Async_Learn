using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLern
{
    class DelThreadStart
    {
        public void DoubleMain()
        {
            Thread th = new Thread(new ThreadStart(Count));
            th.Start();
            for(int i = 1;i<9;i++)
            {
                Console.WriteLine("Главный поток");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
        }
        public static void Count()
        {
            for(int i =1;i<9;i++)
            {
                Console.WriteLine("Второй поток");
                Console.WriteLine(i*i);
                Thread.Sleep(400);
            }
        }
    }
}
