using System;
using System.Threading;
using ThreadLern.SyncThread;

namespace ThreadLern
{
    class Program
    {
        static void Main(string[] args)
        {
            //InfoAboutThread giat = new InfoAboutThread();
            // giat.GetInfoAboutThread();

            // DelThreadStart dts = new DelThreadStart();
            // dts.DoubleMain();

            //ParamThreadStart pts = new ParamThreadStart();
            //pts.DoubleMain();

            //SyncThreadWithLock st = new SyncThreadWithLock();
            //    st.DoubleMain();

            //MonitorThread mt = new MonitorThread();
            //mt.DoubleMain();

            //AREvent are = new AREvent();
            //  are.DoubleMain();

            //  Семафоры позволяют ограничить доступ определенным количеством объектов.
            //SemaphoreLern sl = new SemaphoreLern();
            //sl.DoubleMain();



            TaimerLern tl = new TaimerLern();
            tl.DoubleMain();

        }
    }
}
