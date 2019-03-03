using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Северин Андрей

    //1.	Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Введите положительное число: ");
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(ToBin(number));
            Console.ReadKey();
        }

        static string ToBin(int number, string s ="")
        {
            return number > 0 ? s += ToBin(number / 2, s) + number % 2 : s;
        }
    }

    
}
