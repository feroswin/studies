using System;
using static System.Console;
using static System.Convert;
namespace lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int i, j, n, str = 0, i2,j2;
            double s = 0, min, elem;
            Write("Введите длину измерения массива n = ");
            n = ToInt32(ReadLine());
            double[,] mas = new double[n, n];
            Random r = new Random();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    mas[i, j] = 0;
                    Write("{0,6:0.0}", mas[i,j]);
                }
                WriteLine();
                WriteLine();
            }

            min = mas[0, 0];
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    if (mas[i, j] <= min)
                    {
                        min = mas[i, j];
                        str = i;
                    }
                }

            for (j = 0; j < n; j++)
            {
                s += mas[str, j];
            }
            Write($"Сумма равна {s:0.0}");
        }
    }
}