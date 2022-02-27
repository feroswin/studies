using System;
using static System.Console;
using static System.Convert;

/*  Преобразовать одномерный массив, состоящий из n вещественных элементов, таким
    образом, чтобы сначала располагались все элементы, равные 0, а потом – все
    остальные.
*/

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i,j;
            double t;
            Write("Введите количество элементов массива n = ");
            n = Convert.ToInt32(ReadLine());
            double[] mas = new double[n];
            Random r = new Random();
            WriteLine("Исходный массив");
            for (i = 0; i < n; i++)
            {
                mas[i] = r.Next(-3, 3) /3.0;
                Write("{0,6:0.0}", mas[i]);
            }

            for (i = 0; i < n - 1; i++)
                for (j = 0; j < n - i - 1; j++)
                {
                    if(mas[j] != 0)
                    {
                        t = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = t;
                    }
                }
            WriteLine();
            WriteLine("Отсортированны массив");
            for (i = 0; i < n; i++)
                Write("{0,6:0.0}", mas[i]);
        }
    }
}
