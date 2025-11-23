using System;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.RogozinaMA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {

        public int SecondsToHours(int time)
        {
            // В одном часе 3600 секунд
            // Количество полных часов = общее количество секунд / секунд в часе
            int hours = time / 3600;
            return hours;
        }

    }
}