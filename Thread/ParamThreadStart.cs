using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLern
{
    class ParamThreadStart
    {
        public void DoubleMain()
        {
            Thread th = new Thread(new ParameterizedThreadStart(Count));
            th.Start(new Counter(5,10)) ;
            for(int i=0;i<9;i++)
            {
                Console.WriteLine("Главный поток");
                Console.WriteLine(i*i);
                Thread.Sleep(300);
            }
        }
        public static void Count(object x)
        {
            var con = (Counter)x;
            for(int i = 1;i<9;i++)
            {
                Console.WriteLine("Второй поток выполнеия");
                Console.WriteLine(i*con.x*con.y);
                Thread.Sleep(400);
            }
        }
    }

    //Для нескольких переменных в поток
    public class Counter
    {
        public int x;
        public int y;

        //Делаем типобезопасным
        public Counter(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
