using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //_01_AsyncMeth am = new _01_AsyncMeth();
            //am.DoubleMain();
            //_02_ReadWriteFile rwf = new _02_ReadWriteFile();
            //rwf.DoubleMain();
            //_03_ParamAsync pa = new _03_ParamAsync();
            //pa.DoubleMain();
            //_04_ReturnAsync ra = new _04_ReturnAsync();
            //ra.FactorialAsync(5);
            //Task t = ra.FactorialAsync2(5);
            //Console.WriteLine(t.Status);
            //var r = ra.FactorialAsync3(5);
            //Console.WriteLine(r.Result);
            //var r = ra.FactorialAsync4(5);
            //Console.WriteLine(r.Result);

            //_05_SerialAndParallel sap = new _05_SerialAndParallel();
            //sap.FactorialAsync();

            //_06_ErrorAsync ea = new _06_ErrorAsync();
            //ea.FactorialAsync(-1);
            //var r = ea.DoMultipleAsync();
            //ea.FactorialAsync2(-1);

            //_07_CancelAsync ca = new _07_CancelAsync();
            //ca.DoubleMain();

            //_08_StreamAsync sa = new _08_StreamAsync();
            //sa.DoubleMain();

            _09_StreamAsyncTest sat = new _09_StreamAsyncTest();
            sat.DoubleMain();

            Console.ReadKey();
        }
    }
}
