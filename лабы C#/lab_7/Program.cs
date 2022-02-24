using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, x, s1 = 0, s2 = 0, Ss=0, Sp=0, res, res1, y = 0;
            int i, n;
            Write("Введите n = ");
            n = ToInt32(ReadLine());
            a = 1;
            b = 2;
            x = a;
            h = (b - a) / 2 / n;

            for(i = 0; i < n; i++)
            {
                Sp += (x * Pow(Log(x),2));
                x += 2 * h;
            }
            res1 = (b - a) * Sp / n;
            WriteLine($"Интеграл по формуле прямоугольника = {res1:0.####}");
            
            x = a; 

            for (i = 2; i <= 2 * n - 2; i += 2)
            {
                s1 += (x * Pow(Log(x),2));
                x += 2 * h;
            }
            s1 *= 2;
            x = a;
            for(i = 1; i <= 2 * n - 1; i += 2)
            {
                s2 += (x * Pow(Log(x), 2));
                x += 2 * h;
            }
            s2 *= 4;
            Ss = a * Pow(Log(a), 2) + b * Pow(Log(b), 2) + s1 + s2;
            res = (b - a) * Ss / (6 * n);
            Write($"Интеграл по формуле Симпсона = {res:0.####}");
        }
    }
}
