using System;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskLern tl = new TaskLern();
            //tl.DoubleMain();

            //WaitingForTask wts = new WaitingForTask();
            //wts.DoublMain();

            //SubTask st = new SubTask();
            //st.DoubleMain();

            //MassTask mt = new MassTask();
            //mt.DoubleMain();

            //ReturnResultTask rrt = new ReturnResultTask();
            //rrt.DoubleMain();

            //ContinueTaskWithReturn ct = new ContinueTaskWithReturn();
            //ct.DoubleMain();

            //ParrallelLern pl = new ParrallelLern();
            //pl.DoubleMain();

            //ParralelFor pf = new ParralelFor();
            //  pf.DoubleMain();

            //CancelationTokenLern ctl = new CancelationTokenLern();
            //ctl.DoubleMain();

            CancelParallel cp = new CancelParallel();
            cp.DoubleMain();

            Console.ReadKey();
        }
    }
}
