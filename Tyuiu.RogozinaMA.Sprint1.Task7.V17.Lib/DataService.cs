using System;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RogozinaMA.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            // Формула: z = (1 + sin√(x² + 1)) / cos(12y - 4)
            double numerator = 1 + Math.Sin(Math.Sqrt(x * x + 1));
            double denominator = Math.Cos(12 * y - 4);
            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}