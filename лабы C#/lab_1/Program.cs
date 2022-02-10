using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double z1, z2, alpha, beta;
            Console.Write("Введите число alpha=");
            alpha = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число beta=");
            beta = Convert.ToDouble(Console.ReadLine());
            alpha = alpha / 180.0 * Math.PI;
            beta = beta / 180.0 * Math.PI;
            z1 = Math.Pow(Math.Cos(alpha) - Math.Cos(beta), 2.0) - Math.Pow(Math.Sin(alpha)-Math.Sin(beta), 2.0);
            z2 = -4.0 * Math.Pow(Math.Sin((alpha - beta) / 2.0), 2.0) * Math.Cos(alpha + beta);
            Console.WriteLine($"result z1 = {z1}");
            Console.WriteLine($"result z2 = {z2}");
            Console.ReadKey();
        }
    }
}
