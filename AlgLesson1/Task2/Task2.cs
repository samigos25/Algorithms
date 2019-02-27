using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        //Северин Андрей
        //12. 2. Найти максимальное из четырёх чисел. Массивы не использовать.
        static void Main(string[] args)
        {
            int a, b, c, d;
            Random rnd = new Random();
            for (int i = 0; i < 40; i++)
            {
                a = rnd.Next(-1000, 1000);
                b = rnd.Next(-1000, 1000);
                c = rnd.Next(-1000, 1000);
                d = rnd.Next(-1000, 1000);
                Console.WriteLine($"a = {a,4}, b = {b,4}, c = {c,4}, d = {d,4}: Максимальное = {Max4(a, b, c, d)}");
            }
            Console.ReadKey();
        }

        static int Max4(int a, int b, int c, int d)
        {
            if (a > b && a > c && a > d) return a;
            if (b > c && b > d) return b;
            if (c > d) return c;
            return d;
        }
    }
}
