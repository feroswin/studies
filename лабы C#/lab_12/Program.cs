using System;
using static System.Convert;
using static System.Console;

namespace lab_12
{
    class Program
    {


        static void Vvod(int[,] mas, int k)
        {
            WriteLine();
            Random r = new Random();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    mas[i, j] = r.Next(-10, 10);
                    Write("{0,5:0}", mas[i, j]);
                }
                WriteLine();
            }
        }


        static void Replace(int[,] mas, int k)
        {
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                    if (mas[i, j] > 0)
                        mas[i, j] = 0;
            WriteLine();
        }


        static void Output(int[,] mas, int k)
        {
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                    Write("{0,5:0}", mas[i, j]);
                WriteLine();
            }
            WriteLine();
        }


        static void Main(string[] args)
        {
            int n;
            for (int i = 1; i <= 2; i++)
            {
                Write($"Введите размерность {i} массива n = ");
                n = ToInt32(ReadLine());
                int[,] a = new int[n, n];
                Write($"{i} массив");
                Vvod(a, n);
                Replace(a, n);

                WriteLine($"Измененный {i} массив");
                WriteLine();

                Output(a, n);
            }
        }
    }
}
