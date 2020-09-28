using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace AsyncAwait
{
    class _02_ReadWriteFile
    {
        public void DoubleMain()
        {
            ReadWriteAsync();
            Console.WriteLine("Некоторая работа");
        }

        static async void ReadWriteAsync()
        {
            string s = "Hello world! One stet at a time";
            using(StreamWriter writer =  new StreamWriter("hello.txt",false))
            {
                await writer.WriteLineAsync(s);

            }
            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                string result = await reader.ReadToEndAsync();
                Console.WriteLine(result);
                Thread.Sleep(800);
            }
        }
    }
}
