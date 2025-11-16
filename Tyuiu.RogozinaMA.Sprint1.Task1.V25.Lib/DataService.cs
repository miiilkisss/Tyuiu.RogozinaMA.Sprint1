using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RogozinaMA.Sprint1.Task1.V25.Lib
{
    public class DataService:ISprint1Task1V25
    {
        public double Calculate(double x, double y)
        {
            return (x * y) / (1 + x);
        }
    }
}