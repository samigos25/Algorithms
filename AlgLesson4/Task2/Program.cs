using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{//Северин Андрей

    //не уверен что правильно сделано. К сожалению нет времени разобраться до конца.
    class Program
    {
        static int[] arrI = {9, 5, 2 , 4 , 9 , 7 , 8};
        static int[] arrJ = {1, 5, 3, 2 , 5 , 6, 9 , 7};
        static int[,] resultCol = new int[arrI.Length + 1, arrJ.Length + 1];
        static int[,] resultRow = new int[arrI.Length + 1, arrJ.Length + 1];
        static void Main(string[] args)
        {
            bool flag;
            //по столбцам
            for (int i = 1; i <= arrI.Length; i++)
            {
                flag = false;
                for (int j = 1; j <= arrJ.Length; j++)
                {
                    if (arrI[i - 1] == arrJ[j -1 ] && flag == false)
                    {
                        resultCol[i, j] = Math.Max(resultCol[i- 1 , j], resultCol[i, j - 1]) + 1;
                        flag = true;
                    }
                    else
                    {
                        resultCol[i, j] = Math.Max(resultCol[i - 1, j], resultCol[i, j - 1]);
                    }
                    ;
                }
            }

            printarr(2, resultCol);
            Console.WriteLine();
            //по столбцам
            for (int j = 1; j <= arrJ.Length; j++)
            {
                flag = false;
                for (int i = 1; i <= arrI.Length; i++)
                {
                    if (arrI[i - 1] == arrJ[j - 1] && flag == false)
                    {
                        resultRow[i, j] = Math.Max(resultRow[i - 1, j], resultRow[i, j - 1]) + 1;
                        flag = true;
                    }
                    else
                    {
                        resultRow[i, j] = Math.Max(resultRow[i - 1, j], resultRow[i, j - 1]);
                    }
                }
            }
            printarr(2,resultRow);
            Console.WriteLine();
            Console.ReadKey();
        }

        static void printarr(int pad, int[,] arr)
        {
            Console.Write("    ");
            foreach (var ar in arrJ)
            {
                Console.Write(ar.ToString().PadLeft(pad));
            }

            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i != 0) Console.Write(arrI[i - 1].ToString().PadLeft(pad));
                else Console.Write("  ");

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j].ToString().PadLeft(pad));
                }

                Console.WriteLine();
            }
        }
    }
}
