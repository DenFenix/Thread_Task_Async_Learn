using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLern
{
    class InfoAboutThread
    {       
        public void GetInfoAboutThread()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine($"Имя потока {t.Name}");
            t.Name = "Метод Main";
            Console.WriteLine($"Имя потока {t.Name}");
            Console.WriteLine($"Запущен ли поток: {t.IsAlive}");
            Console.WriteLine($"Приоритет потока: {t.Priority}");
            Console.WriteLine($"Статус потока: {t.ThreadState}");


            //Получаем домен приложений
            Console.WriteLine($"Домен приложения: {t.ThreadState}");
            Console.WriteLine();
        }
    }
}
