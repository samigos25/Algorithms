using System;

namespace Task14
{
    //Северин Андрей

    //14. * Автоморфные числа.Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата.
    //Например, 25 \ :sup: '2' = 625.
    //Напишите программу, которая получает на вход натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.
    class Task14
    {
        static void Main(string[] args)
        {
            uint number;
            Console.Write("Введите натуральное число: ");
            number = UInt32.Parse(Console.ReadLine());
            if (number == TakeLast(number * number, NumberLen(number)))
            {
                Console.WriteLine("Автоморфное число");
            }
            else
            {
                Console.WriteLine("Не автоморфное число");

            }
            

            for (uint i = 0; i < 1_000_000; i++)
            {
                if (i == TakeLast(i * i, NumberLen(i)))
                {
                    Console.WriteLine("Автоморфное число {0}", i);
                }
            }

            Console.ReadKey();
        }

        static uint TakeLast(uint number , short count)
        {
            uint result = 0;
            for (int i = 0; i < count; i++)
            {
                result = result + number % 10 * (uint)Math.Pow(10, i) ;
                number /= 10;
            }
            return result;
        }
        static short NumberLen(uint number)
        {
            short result = 0;
            while (number > 0)
            {
                number /= 10;
                result++;
            }
            return result;
        }
    };
}
