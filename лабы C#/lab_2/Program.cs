using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, a, h;
            Console.WriteLine("Введите высоту прямоугольного параллелепипеда");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону куба");
            a = Convert.ToDouble(Console.ReadLine());
            volume = a * a * (a-h);
            Console.WriteLine($"Объем полученной фигуры равен {volume} кубических единиц");
            Console.ReadKey();
        }
    }
}
