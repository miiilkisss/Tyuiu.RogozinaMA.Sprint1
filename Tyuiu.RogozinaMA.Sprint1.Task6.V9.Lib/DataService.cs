using System;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.RogozinaMA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    string word = words[i];
                    char lastChar = word[word.Length - 1];
                    words[i] = lastChar + word.Substring(0, word.Length - 1);
                }
            }

            return string.Join(" ", words);
        }
    }
}