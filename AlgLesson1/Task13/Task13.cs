using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    //Северин Андрей
    //13. * Написать функцию, генерирующую случайное число от 1 до 100: 
    //a.С использованием стандартной функции rand().
    //b.Без использования стандартной функции rand().

    class Task13
    {
        private static int prevRand = 15;
        private static readonly Random Rng = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.SetCursorPosition(i * 4, 0);
                Console.Write(Rnd100UseLib());
            }

            for (int i = 0; i < 15; i++)
            {
                Console.SetCursorPosition(i * 4, 1);
                Console.Write(Rnd100Own());
            }

            List<int> list = Enumerable.Repeat(0,100).ToList();
            for (int i = 0; i < 10000; i++)
            {
                list[Rnd100Own()] ++;
            }
            Console.ReadKey();
        }

        static int Rnd100UseLib()
        {
            return Rng.Next(1, 100);
        }

        static int Rnd100Own()
        {
            prevRand = Math.Abs(DateTime.Now.Ticks.GetHashCode() * prevRand + 1013904223) % 100;
            return prevRand;
        }
    }
}
