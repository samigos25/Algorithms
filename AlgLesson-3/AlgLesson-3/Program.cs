using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HelperArray;

namespace AlgLesson_3
{
    class Program
    {
        static long count = 0;
        static void Main(string[] args)
        {
            int elementsCount = 10000;
            int[] arr = StaticClass.GenerateRandomArray(elementsCount, -1000, 1000);
            //StaticClass.PrintArray(" ", 4, arr);
            Sheik(arr);
            //StaticClass.PrintArray(" ", 4, arr);
            Console.WriteLine("Массив из 10000 эелементов");
            Console.WriteLine($"Шейкерная сортировка {count}");
            count = 0;

            BubbleSort(arr);
            Console.WriteLine($"Обычная пузырьковая {count}");
            count = 0;
            arr = StaticClass.GenerateRandomArray(elementsCount, -1000, 1000);
            BubbleSortOpt(arr);
            Console.WriteLine($"Улучшенная пузырьковая {count}");

            Console.WriteLine("Ищем -249");
            Console.WriteLine(BinarySearch(arr, -249));
            Console.ReadKey();
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            for (int j = 0; j < arr.Length - 1; j++)
            {
                count++;
                if (arr[j] > arr[j + 1]) (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);

            }
        }
        public static void BubbleSortOpt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                count++;
                if (arr[j] > arr[j + 1]) (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);

            }
        }

        public static void Sheik(int[] arr)
        {
            uint tick = 0;  
            for (int i = 0; i < arr.Length; i++)
            {
                for (uint j = tick; j < arr.Length - 1; j++)
                {
                    count++;
                    if (arr[j] > arr[j + 1]) (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }

                for (int j = arr.Length - i - 1; j > tick + 1; j--)
                {
                    count++;
                    if (arr[j] < arr[j - 1]) (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                }

                i++;
                tick++;
            }


        }

        static int BinarySearch(int[] arr, int number)
        {
            int start = 0;
            int end = arr.Length;
            int cur;
            while (start <= end)
            {
                cur = (end + start) / 2;
                if (number < arr[cur]) end = cur - 1;
                else if (number > arr[cur]) start = cur + 1;
                else return cur;
            }
            return -1;
        }
    }


}
