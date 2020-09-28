using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLern.SyncThread
{
    class AREvent
    {
        //изначально в сигнальном состоянии
        static AutoResetEvent waitHandler = new AutoResetEvent(true);

        static int x = 0;
        public void DoubleMain()
        {
            for (int i = 0;i<5;i++)
            {
                Thread mt = new Thread(Count);
                mt.Name = $"Поток {i.ToString()}";
                mt.Start();
            }
        }

        private void Count()
        {
            //Первый потокзаватывает данный объект и выполняет код
            //Другой поток переведётся в состояние ожидания, пока waitHandler не освободиться
            waitHandler.WaitOne();
            //WaitHandle базовый класс для AutoResetEvent хз как применять
            //AutoResetEvent.WaitAll(new WaitHandle[] { waitHandler });
            x = 1;
            for (int i = 1; i <9;i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
                x++;
                Thread.Sleep(100);

            }
            //увежомляет все потоки, что waitHandler вновь в сигнальном состоянии
            waitHandler.Set();
        }
    }
}
