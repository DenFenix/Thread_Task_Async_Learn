using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLern
{
    class SyncThreadWithLock
    {
        static int x = 1;
        static object locker = new object();
        public void DoubleMain()
        {
            for (int i =0; i<5;i++)
            {
                Thread th = new Thread(Count);
                th.Name = i.ToString();
               // Console.WriteLine($"Имя потока:{th.Name}");
                Console.WriteLine("Поток" + i.ToString());
                th.Start();
            }
        }
        
        public static void Count()
        {
            //для других потоков до завершения работы текущего потока
            lock (locker)
            {
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: - {x}");
                    x++;
                    Thread.Sleep(100);
                }
            }
          
        }
    }

}
