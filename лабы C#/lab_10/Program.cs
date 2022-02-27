using System;
using static System.Console;
using static System.Convert;

/*  
    Заполнить матрицу случайными числами. На главной диагонали разместить суммы
    элементов, которые лежат на соответствующих строках.
*/

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            double s;
            Write("Введите длину измерения массива n = ");
            n = ToInt32(ReadLine());
            WriteLine("Исходный массив:");
            double[,] mas = new double[n, n];
            Random r = new Random();
            for (i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    mas[i, j] = r.Next(-10,15) /2.0;
                    Write("{0,5:0.0}", mas[i,j]);
                }
                WriteLine();
                WriteLine();
            }
            for (i = 0; i < n; i++)
            {
                s = 0;
                for(j = 0; j < n; j++)
                {
                    s += mas[i, j];
                }
                mas[i, i] = s;
            }
            WriteLine("Изменненый массив:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Write("{0,5:0.0}", mas[i, j]);
                WriteLine();
                WriteLine();
            }
        }
    }
}
