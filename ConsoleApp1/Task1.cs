using System;

namespace ConsoleApp1
{
    class Task1
    {
        static void Main(string[] args)
        {
            
            int n;
            Console.WriteLine("Завдання 1\nВедіть розмір масиву");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Ведіть елементи масиву:");

            string []mes = new string[n];
            for (int i = 0; i < n; i++)
            {
                mes[i] = Console.ReadLine();
            }
            Array.Sort(mes, (x, y) => x[0].CompareTo(y[0]));
            Console.WriteLine("Результат:");
            foreach (var message in mes)
            {
                Console.WriteLine(message);
            }
            
        }
    }
}
