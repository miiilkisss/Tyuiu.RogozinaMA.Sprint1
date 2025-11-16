using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RogozinaMA.Sprint1.Task1.V25.Lib;

namespace Tyuiu.RogozinaMA.Sprint1.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Спринт #1                                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                  *");
            Console.WriteLine("* Задание #1                                                        *");
            Console.WriteLine("* Вариант #25                                                       *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                  *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные   *");
            Console.WriteLine("* данные, вычисляет результат по формуле (x*y)/(1+x)                *");
            Console.WriteLine("* и печатает его на экране.                                         *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                  *");
            Console.WriteLine("*********************************************************************");

            // Запрос данных у пользователя
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                        *");
            Console.WriteLine("*********************************************************************");

            // Вычисление результата через библиотеку
            double result = ds.Calculate(x, y);
            Console.WriteLine($"{result:F2}"); // Округление до 2 знаков после запятой

            Console.ReadLine();
        }
    }
}