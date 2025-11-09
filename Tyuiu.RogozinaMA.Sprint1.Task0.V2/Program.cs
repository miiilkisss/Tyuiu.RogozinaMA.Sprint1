using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RogozinaMA.Sprint1.Task0.V2.Lib;




namespace Tyuiu.RogozinaMA.Sprint1.Task0.V2
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
            Console.WriteLine("* Задание #0                                                        *");
            Console.WriteLine("* Вариант #2                                                        *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                  *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 3/3*2+12/4/3-2    *");
            Console.WriteLine("*  и печатает результат на экране.                                  *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                   *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*3/3*2+12/4/3-2                                                     *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                        *");
            Console.WriteLine("*********************************************************************");



            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}