using System;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.RogozinaMA.Sprint1.Task4.V4.Lib
{
    public class DataService : ISprint1Task4V4
    {
        public double Calculate(double x, double y)
        {
            // Формула: (1 + x*y) / |x + 2|
            double numerator = 1 + x * y;
            double denominator = Math.Abs(x + 2);
            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}