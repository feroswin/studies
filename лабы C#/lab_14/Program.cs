using System;
using static System.Console;
using static System.Convert;

namespace lab_14
{

    struct car
    {
        public string brand;
        public string num;
        public int year;
        public int price;
        public void Vvod()
        {
            WriteLine();
            Write("Введите марку автомобиля: ");
            brand = ReadLine();
            Write("Введите номерной знак: ");
            num = ReadLine();
            Write("Введите год выпуска: ");
            year = ToInt32(ReadLine());
            Write("Введите стоимость: ");
            price = ToInt32(ReadLine());
            WriteLine();
        }
        public void DisplayInfo()
        {
            WriteLine();
            WriteLine($"Марка автомобиля: {brand}");
            WriteLine($"Номерной знак: {num.ToUpper()}");
            WriteLine($"Год выпуска: {year} г.");
            WriteLine($"Стоимость: {price} руб.");
            WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int year_src;
            Write("Введите количество автомобилей ");
            n = ToInt32(ReadLine());
            car[] cars = new car [n];
            for (i = 0; i < n; i++)
            {
                Write($"{i+1} - автомобиль");
                cars[i].Vvod();
            }

            Write("Введите год выпуска автомобиля для поиска ");
            year_src = ToInt32(ReadLine());

            for (i = 0; i < n; i++)
            {
                if(cars[i].year == year_src)
                {
                    cars[i].DisplayInfo();
                }
            }

        }
    }
}
