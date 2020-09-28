using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLern.SyncThread
{/// <summary>
///  Семафоры позволяют ограничить доступ определенным количеством объектов.
/// </summary>
    class SemaphoreLern
    {
        public void DoubleMain()
        {
            for(int i = 0; i<5;i++)
            {
                Reader reader = new Reader(i);
            }
        }
    }

    class Reader
    {
        //создаём симвфор
        // указывает, какому числу объектов изначально будет доступен семафор
        // указывает, какой максимальное число объектов
        static Semaphore sem = new Semaphore(2, 2);
        Thread myThread;
        int count = 4;// счётчик чтения, сколько раз будет читать

        public Reader(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = $"Читатель {i.ToString()}";
            myThread.Start();
        }

        private void Read(object obj)
        {
            while(count>0)
            {
                sem.WaitOne();

                Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

                Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

                sem.Release();
                count--;
                Thread.Sleep(1000);
            }
        }
    }
}
