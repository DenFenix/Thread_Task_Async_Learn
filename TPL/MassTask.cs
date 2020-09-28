using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class MassTask
    {
        public void DoubleMain()
        {
            Task[] ts = new Task[3]
            {
                new Task(()=>Console.WriteLine("First Task")),
                new Task(()=>Console.WriteLine("Second Task")),
                new Task(()=>Console.WriteLine("Third Task"))
            };
            foreach (var t in ts)
                t.Start();
            

            Task[] ts2 = new Task[3];
            int j = 1;
            for (int i = 0; i < ts2.Length; i++)
            {
                ts2[i] = Task.Factory.StartNew(() => Console.WriteLine($"Task {j++}"));
            }
            Task.WaitAll(ts);//завершатся все задачи, потом Main:
            //Task.WaitAll(ts2);
            Console.WriteLine("Завершение метода Main");
        }

    }
}
