using System;
using static System.Console;
using static System.Convert;


/*  В одномерном массиве, состоящем из n вещественных элементов, вычислить:
        а) количество элементов массива, равных 0;
        b) сумму элементов массива, расположенных после минимального элемента.
*/

namespace lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n, k=0, num_min = 0;
            double s = 0, min;
            Write("Введите количество элементов массива n = ");
            n = ToInt32(ReadLine());
            double[] mas = new double[n];
            Random r = new Random();
            for (i = 0; i < n; i++)
            {
                mas[i] = r.Next(-2, 3) / 2.0;
                Write("{0,6:0.0}", mas[i]);
                if (mas[i] == 0) k++;
            }

            min = mas[0];
            for (i = 0; i < n; i++)
            {
                if (mas[i] <= min)
                {
                    min = mas[i];
                    num_min = i;
                }
            }
            for (i = num_min+1; i < n; i++)
            {
                s += mas[i]; 
            }
            WriteLine();
            WriteLine($"Количество элементов массива, равных 0 = {k}");
            Write($"Сумма элементов массива, расположенных после минимального элемента = {s}");
        }
    }
}
