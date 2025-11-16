using System;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.RogozinaMA.Sprint1.Task2.V24.Lib
{
    public class DataService : ISprint1Task2V24
    {
        public int CalculateDiffSquare(int number1, int number2)
        {
            int difference = number1 - number2;
            return difference * difference;
        }
    }
}