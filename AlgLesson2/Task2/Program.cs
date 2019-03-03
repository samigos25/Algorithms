using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        //Северин Андрей

        //2.	Реализовать функцию возведения числа a в степень b:
        //      a.Без рекурсии.
        //      b.Рекурсивно.
        //      c.  *Рекурсивно, используя свойство чётности степени.

        static void Main(string[] args)
        {
            int number;
            int power;
            Console.Write("Введите положительное число: ");
            number = Int32.Parse(Console.ReadLine());
            Console.Write("Введите степень в которую возвести число: ");
            power = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Power(number,power));
            Console.WriteLine(PowerRecurs(number,power));
            Console.WriteLine(PowerRecursEvenPower(number,power));
            Console.ReadKey();
        }

        static long Power(int number, int power)
        {
            long result = number;
            for (int i = 0; i < power - 1; i++)
            {
                result *= number;
            }
            return result;
        }

        static long PowerRecursEvenPower(long number, int power, long start = 1)
        {
            start = start == 1 ? number : start;
            if (power % 2 == 0)
                return power == 2 ? number * number : PowerRecursEvenPower(PowerRecursEvenPower(number, power / 2, start), 2, start);
            return power == 1 ? number : PowerRecursEvenPower(number, 1, start) * PowerRecursEvenPower(number, power - 1, start);
        }

        static long PowerRecurs(long number, int power, long start = 1)
        {
            start = start == 1 ? number : start;
            return power > 1 ? PowerRecurs(number * start, power - 1, start) : number;
        }

    }
}
