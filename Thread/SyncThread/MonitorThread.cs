using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLern
{
    class MonitorThread
    {
        static int x = 0;
        static object locker = new object();

        public void DoubleMain()
        {
            for (int i = 0; i <5;i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = $"Поток {i.ToString()}";
                myThread.Start();
                
            }
   

        }
        public static void Count()
        {
            bool acquiredLock = false;
            try
            {
                //в монитор разворачивается lock
                Monitor.Enter(locker, ref acquiredLock);
                x = 1;
                for(int i = 1; i <9;i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
                    x++;
                    Thread.Sleep(100);
                    //if (Thread.CurrentThread.Name == "Поток 1")
                      //  Monitor.Wait(locker);
                }
            }
            finally
            {
                if (acquiredLock) Monitor.Exit(locker);
            }
            
        }
    }
}
