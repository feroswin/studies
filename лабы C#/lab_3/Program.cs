using System;
using static System.Console;
using static System.Convert;
using static System.Math;

/*
    Написать программу, проверяющую, есть ли среди чисел а, b, с хотя бы одна пара
    взаимно противоположных.
*/

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, num_pairs = 0;
            Write("Введите число a=");
            a = ToDouble(ReadLine());
            Write("Введите число b=");
            b = ToDouble(ReadLine());
            Write("Введите число c=");
            c = ToDouble(ReadLine());
            if ((a != b) && (a == Abs(b) || Abs(a) == b))
            {
                num_pairs ++;
                if (b == Abs(c) || Abs(b) == c)
                    num_pairs++;
            }
            else if ((a != c) && (a == Abs(c) || Abs(a) == c))
            {
                num_pairs++;
                if (c == Abs(b) || Abs(c) == b)
                    num_pairs++;
            }
            else if ((b != c) && (b == Abs(c) || Abs(b) == c))
            {
                num_pairs++;
                if (c == Abs(a) || Abs(c) == a)
                    num_pairs++;
            }
            Write($"Количество пар взаимно противоположных чисел равно {num_pairs}");
            ReadKey();
        }
    }
}
