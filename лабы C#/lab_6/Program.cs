using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xn, Xk, dx, eps, x , s, f, sl=0;
            int i, n;

            Write("Введите xn = ");
            Xn = ToDouble(ReadLine());
            Write("Введите xk = ");
            Xk = ToDouble(ReadLine());
            Write("Введите dx = ");
            dx = ToDouble(ReadLine());
            Write("Введите eps = ");
            eps = ToDouble(ReadLine());
            Write("\tx\tS(x)\t  ln(x)\t      n");
            for (x = Xn; x <= Xk; x += dx)
            {
                WriteLine();
                s = x-1.0;
                for(f = x-1, i = 2, n=0; Abs(f) > eps; i++)
                {
                    f = (-f * (x-1)) / (i / (i-1.0));
                    s += f;
                    n = i;
                }
                Write("{0,9:0.####}{1,11:0.####}{2,11:0.####}{3,11:0.#}", x, s, Log(x), n);
            }
        }
    }
}
