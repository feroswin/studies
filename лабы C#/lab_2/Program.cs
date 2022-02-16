using System;
using static System.Convert;
using static System.Console;
using static System.Math;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, angle;
            Write("Введите сторону a= ");
            a = ToDouble(ReadLine());
            Write("Введите сторону b= ");
            b = ToDouble(ReadLine());
            Write("Введите сторону c= ");
            c = ToDouble(ReadLine());
            angle = Acos((a * a + c * c - b * b) / (2 * a * c));
            angle *= 180 / PI;
            Write($"Угол a (в градусах) равен {angle:###.##}");
            ReadKey();
        }
    }
}
