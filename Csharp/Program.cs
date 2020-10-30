using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allmonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            Console.WriteLine("Введите количество дней:");
            int day = Convert.ToInt32(Console.ReadLine());
            int year = day / 365;
            int i = 0;
            int k = 0;
            int month = 0;
            day = day % 365;
            while (day - allmonth[i] > 0)
                    {
                day = day - allmonth[month];
                month++;
                    }
            Console.WriteLine($"Лет = {year} \nМесяцев = {month} \nДней = {day}");
            Console.ReadKey();
        }
    }
}
