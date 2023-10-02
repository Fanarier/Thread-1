using System;
using System.Diagnostics;
using System.Threading;
// Плотников Кирилл 
// 22.ИСП.2/3
// Номер задания: 14.35
// Задание: Даны два предложения. Найти общее количество букв н в  них. (Определить функцию для расчета количества букв н в предложении.)

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        {
            string sentence1 = "нет?";
            string sentence2 = "У меня все хорошо.";

            Thread thread1 = new Thread(() => CountAndPrint(sentence1));
            Thread thread2 = new Thread(() => CountAndPrint(sentence2));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        static void CountAndPrint(string sentence)
        {
            int count = 0;

            foreach (char letter in sentence)
            {
                if (letter == 'н' || letter == 'Н')
                {
                    count++;
                }
            }

            Console.WriteLine("Количество букв 'н' в предложении: " + count);
        }

        stopwatch.Stop();

        Console.WriteLine("Время запуска консоли: {0} мс", stopwatch.ElapsedMilliseconds);

        Console.WriteLine("Время запуска консоли: {0} тиков", stopwatch.ElapsedTicks);
    }
}