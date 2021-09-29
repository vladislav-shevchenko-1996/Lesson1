using System;
using System.Text.RegularExpressions;

namespace Task4
{
    class Task4
    {
        public static bool Palindrom(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок:");
            string mes = Console.ReadLine().ToUpper();
            mes = Regex.Replace(mes, "[-.?!)(,: ]", String.Empty);
            if (Palindrom(mes) == true)
                Console.WriteLine("Рядок є паліндромом.");
            else Console.WriteLine("Рядок не є паліндромом");
        }
    }
}
