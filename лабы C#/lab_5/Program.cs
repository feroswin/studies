using System;
using static System.Convert;
using static System.Console;
using static System.Math;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, ost;
            Write("Введите число x= ");
            x = ToInt32(ReadLine());
            ost = x % 8;
            switch (ost)
            {
                case 0:
                    Write($"Остаток от деления на 8 числа {x} равен нулю");
                    break;
                case 1:
                    Write($"Остаток от деления на 8 числа {x} равен единице");
                    break;
                case 2:
                    Write($"Остаток от деления на 8 числа {x} равен двум");
                    break;
                case 3:
                    Write($"Остаток от деления на 8 числа {x} равен трем");
                    break;
                case 4:
                    Write($"Остаток от деления на 8 числа {x} равен четырем");
                    break;
                case 5:
                    Write($"Остаток от деления на 8 числа {x} равен пяти");
                    break;
                case 6:
                    Write($"Остаток от деления на 8 числа {x} равен шести");
                    break;
                case 7: 
                    Write($"Остаток от деления на 8 числа {x} равен семи");
                    break;
            }
            ReadKey();
        }
    }
}
