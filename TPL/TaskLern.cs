using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class TaskLern
    {
        public void DoubleMain()
        {
            /*
            AsyncState: возвращает объект состояния задачи
            CurrentId: возвращает идентификатор текущей задачи
            Exception: возвращает объект исключения, возникшего при выполнении задачи
            Status: возвращает статус задачи
             */

            //Создание задачи
            //Первый метод
            //параметром принимает класс Action
            Task task = new Task(() => Console.WriteLine("Hello Task"));
            task.Start();

            //второй метод без new, статический метод
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello Task!"));

            //3 способ использование статического метода ран
            Task task3 = Task.Run(() => Console.WriteLine("Helo Task")); 

        }
    }
}
