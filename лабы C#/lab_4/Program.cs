using System;
using static System.Convert;
using static System.Console;
using static System.Math;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Write("Введите x = ");
            x = ToDouble(ReadLine());
            Write("Введите y = ");
            y = ToDouble(ReadLine());
            if ((x >= 0 && x * x + y * y <= 16) || (x >= 0 && x * x + y * y <= 25))
                Write($"Точка с координатами ({x}, {y}) попадает в заштрихованную область");
            else
                Write($"Точка с координатами ({x}, {y}) не попадает в заштрихованную область");
            ReadKey();
        }
    }
}
