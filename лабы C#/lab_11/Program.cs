using System;
using static System.Console;
using static System.Convert;
namespace lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, i2=0, k;
            double s=0, min;
            Write("Введите размерность n = ");
            n = ToInt32(ReadLine());
            double[,] mas = new double[n, n];
            Random r = new Random();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    mas[i, j] = r.Next(-35, 35) / 2.7;
                    for (k = 0; k < n; k++)
                    {
                        if (mas[i, j] == mas[i, k])
                        {
                            mas[i, j] = r.Next(-35, 35) / 2.7;
                        }
                    }
                    Write("{0,6:0.#}", mas[i,j]);
                }
                WriteLine();
                WriteLine();
            }

            min = mas[0, 0];
            for (i = 0; i < n; i++)
                for(j = 0; j < n; j++)
                {
                    if(mas[i,j] <= min)
                    {
                        min = mas[i, j];
                        i2 = i;
                    }
                }


            for(j = 0; j < n; j++)
            {
                s += mas[i2, j];
            }
            Write($"Сумма элементов строки, в которой расположен элемент с наименьшим значением {s:0.#}");
            ReadKey();
        }
    }
}
