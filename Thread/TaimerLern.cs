using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLern
{
    class TaimerLern
    {
        
        public void DoubleMain()
        {
            //устанавлеваем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            int num = 0;

            //создаём таймер
            //будет работать каждые 2 секунды после запуска
            Timer timer = new Timer(tm, num, 0, 2000);

            Console.ReadLine();
        }


        private static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
        }
    }

    
}
