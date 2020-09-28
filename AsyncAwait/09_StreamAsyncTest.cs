using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class _09_StreamAsyncTest
    {
        public async Task DoubleMain()
        {
            Repository r = new Repository();
            await foreach (var str in r.GetDataAsync())
            {
                Console.WriteLine(str);
            }
        }
    }

    class Repository
    {
        string[] data = { "Tom", "Sam", "Kate", "Alice", "Bob" };
        public async IAsyncEnumerable<string> GetDataAsync()
        {
            for(int i = 0; i<data.Length;i++)
            {
                Console.WriteLine($"Получаем {i + 1} элумент");
                await Task.Delay(100);
                yield return data[i];
            }
        }
    }
}
