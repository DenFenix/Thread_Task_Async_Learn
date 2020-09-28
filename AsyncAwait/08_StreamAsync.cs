using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class _08_StreamAsync
    {
        public  async Task DoubleMain()
        {
            await foreach ( var number in GetNumberAsync())
            {
                Console.WriteLine(number);
            }
        }

        public static async IAsyncEnumerable<int> GetNumberAsync()
        {
            for(int i =0;i<10;i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}
