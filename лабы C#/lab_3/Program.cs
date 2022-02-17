using System;
using static System.Console;
using static System.Convert;
using static System.Math;



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
            if (a + b == 0 || a + c == 0 || b + c == 0)
                Write("Взаимно противоположные числа есть");
            else
                Write("Взаимно противоположных чисел нет");
            ReadKey();
        }
    }
}
