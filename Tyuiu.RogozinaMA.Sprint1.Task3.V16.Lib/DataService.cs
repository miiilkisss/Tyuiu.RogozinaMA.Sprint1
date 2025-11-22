using System;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.RogozinaMA.Sprint1.Task3.V16.Lib
{
    public class DataService : ISprint1Task3V16
    {
        public double CoeffOfQuadraticEquation(double x1, double x2)
        {
            // Для квадратного уравнения: x² + bx + c = 0
            // По теореме Виета: b = -(x1 + x2)
            double b = -(x1 + x2);
            return Math.Round(b, 3);
        }
    }
}