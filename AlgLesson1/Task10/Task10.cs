using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    //Дано целое число N > 0. С помощью операций деления нацело и взятия остатка от
    //деления определить, имеются ли в записи числа N нечётные цифры.
    //Если имеются, то вывести True, если нет – вывести False.
    class Task10
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int t;
            bool flag;
            for (int i = 0; i < 40; i++)
            {
                flag = false;
                t = rnd.Next(0, 1_000);
                Console.Write("Число {0}: ", t);
                while (t > 0)
                {
                    if ((t % 10) % 2 == 1)
                    {
                        flag = true;
                        break;
                    }
                    t /= 10;
                }

                Console.WriteLine(flag);
            }
            Console.ReadKey();
        }
    }
}
