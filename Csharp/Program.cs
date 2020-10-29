using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество дней:");
            int day = Convert.ToInt32(Console.ReadLine());
            int year = day / 365;
            int month = (day % 365) / 30;
            day = (day % 365) % 30;
            Console.WriteLine($"Летт = {year} \nМесяцев = {month} \nДней = {day}");
            Console.ReadKey();
        }
    }
}
