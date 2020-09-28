using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLern.SyncThread
{
    class MutexLern
    {
        //изначально в сигнальном состоянии
        static Mutex mutexObj = new Mutex();

        static int x = 0;
        public void DoubleMain()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread mt = new Thread(Count);
                mt.Name = $"Поток {i.ToString()}";
                mt.Start();
            }
        }

        private void Count()
        {
            //Приостанавливает работу, пока не будет получен мьютекс
            mutexObj.WaitOne();
          
            x = 1;
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
                x++;
                Thread.Sleep(100);

            }
            //увежомляет все потоки, что waitHandler вновь в сигнальном состоянии
            mutexObj.ReleaseMutex();
        }
    }
}
