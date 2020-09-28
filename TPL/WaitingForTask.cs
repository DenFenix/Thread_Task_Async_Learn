using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class WaitingForTask
    {
        public void DoublMain()
        {
            Task ts = new Task(Display);
            ts.Start();
            //чтобы указать, что Main должен ждать конца работы Wait;
            ts.Wait();
            Console.WriteLine("Окончание работы Main");

        }
        static void Display()
        {
            Console.WriteLine("Начало работы дисплей");
            Console.WriteLine("Окончание работы дисплей");
        }

    }
}
