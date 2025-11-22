using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RogozinaMA.Sprint1.Task3.V16.Lib;
  
namespace Tyuiu.RogozinaMA.Sprint1.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Программа вычисляет коэффициент приведенного квадратного уравнения,     *");
            Console.WriteLine("* корнями которого являются введенные два вещественных числа.             *");
            Console.WriteLine("* (b = -x1 - x2). Ответ округлить до 3 знаков после запятой.              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Запрос данных у пользователя
            Console.Write("Введите первый корень (x1): ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второй корень (x2): ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вычисление результата через библиотеку
            double result = ds.Calculate(x1, x2);
            Console.WriteLine($"Коэффициент b квадратного уравнения с корнями {x1} и {x2} = {result:F3}");

            Console.ReadLine();
        }
    }
}