using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Task9
    {
        //Северин Андрей
        //9. Даны целые положительные числа N и K.Используя только операции сложения и вычитания,
        //найти частное от деления нацело N на K, а также остаток от этого деления.

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a, b;
            for (int i = 0; i < 40; i++)
            {
                a = rnd.Next(0, 1000);
                b = rnd.Next(0, 100);
                var (whole, module) = Modulo(a, b);
                Console.WriteLine($"Дано число {a, 4} и делитель {b,3}: Неполное частное {whole,3} остаток от деления {module,2}");
            }

            a = 15;
            b = 50;
            var tup = Modulo(a, b);
            Console.WriteLine($"\nДано число {a,4} и делитель {b,3}: Неполное частное {tup.whole,3} остаток от деления {tup.module,2}");
            Console.ReadKey();
        }

        static (int whole, int module) Modulo(int number, int modul)
        {
            int whole = 0;
            while (number > modul)
            {
                number -= modul;
                whole++;
            }

            return (whole, number);
        }
    }
}
