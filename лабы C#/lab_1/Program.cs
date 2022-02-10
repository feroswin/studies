using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double z1, z2, x, y;
            Console.Write("Введите число x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число y=");
            y = Convert.ToDouble(Console.ReadLine());
            z1 = Math.Pow(Math.Cos(x), 4.0) + Math.Pow(Math.Sin(y), 2.0) + (1.0 / 4.0) * Math.Pow(Math.Sin(2 * x), 2.0) - 1.0;
            Console.WriteLine($"result z1= {z1}");
            z2 = Math.Sin(x + y) * Math.Sin(y - x);
            Console.WriteLine($"result z2= {z2}");
            Console.ReadKey();
        }
    }
}
