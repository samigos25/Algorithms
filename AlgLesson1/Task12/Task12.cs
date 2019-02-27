using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Task12
    {
        //Северин Андрей
        //12. Написать функцию нахождения максимального из трёх чисел.

        static void Main(string[] args)
        {
            int a, b, c;
            Random rnd = new Random();
            for (int i = 0; i < 40; i++)
            {
                a = rnd.Next(-1000, 1000);
                b = rnd.Next(-1000, 1000);
                c = rnd.Next(-1000, 1000);
                Console.WriteLine($"a = {a,4}, b = {b,4}, c = {c,4} : Максимальное = {Max3(a,b,c)}");
            }
            Console.ReadKey();
        }

        static int Max3(int a, int b, int c)
        {
            if (b > a && b > c) return b;
            if (c > a) return c;
            return a;
        }
    }
}
