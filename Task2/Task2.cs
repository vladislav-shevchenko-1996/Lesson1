using System;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 2\nВедіть рядок слів:");
            string line = Console.ReadLine();
            string[] words = line.Split(new char[] { '.', ',', ';', ' ', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            Console.WriteLine(string.Join(' ', words));
        }
    }
}
