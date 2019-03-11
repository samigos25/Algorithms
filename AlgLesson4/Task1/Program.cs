using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static int[,] arr = new int[,]
        {
            {1, 1, 1, 1, 1, 1, 1, 1},
            {1, 1, 1, 1, 1, 1, 1, 1},
            {1, 1, 1, 1, 1, 1, 0, 1},
            {1, 1, 0, 1, 1, 1, 1, 1},
            {1, 1, 0, 1, 1, 1, 1, 1},
            {0, 1, 0, 1, 1, 1, 1, 1},
            {0, 1, 1, 1, 1, 1, 0, 1},
            {0, 1, 1, 1, 1, 1, 1, 1}
        };

        static void Main(string[] args)
        {
            printarr(2);

            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    
                    arr[i, j] = arr[i, j] != 0 ? arr[i - 1, j] + arr[i, j - 1] : 0;
                }
            }

            Console.WriteLine();
            printarr(5);

            Console.ReadKey();
        }

        static void printarr(int pad)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(arr[i, j].ToString().PadLeft(pad));
                }

                Console.WriteLine();
            }
        }

    }
}
