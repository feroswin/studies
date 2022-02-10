using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int time, hours, minutes;
            Console.Write("Введите количество минут ");
            time = Convert.ToInt32(Console.ReadLine());
            hours = time / 60;
            minutes = time % 60;
            Console.WriteLine($"Время в необходимом формате {hours} ч {minutes} мин");
            Console.ReadKey();
        }
    }
}
