using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class ReturnResultTask
    {
        public void DoubleMain()
        {
            Task<int> ts = new Task<int>(()=>Factorial(5));
            ts.Start();
            Console.WriteLine($"Факториал числа 5 равен {ts.Result}");
            Task<Book> task2 = new Task<Book>(()=> 
            {
                return new Book { Title = "Война и мир", Autor = "Л. Толстой" }; 
            });
            task2.Start();

            Book b = task2.Result;
            Console.WriteLine($"Название книги: {b.Title}, автор {b.Autor}");
        }

        private int Factorial(int v)
        {
            int result =1;
            for(int i = 1; i<=v;i++)
            {
                result *= i;
            }
            return result;
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
    }
}
