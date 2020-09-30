using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewTasks.AnagramsInString
{
    public static class Anagram
    {
        public static ArrayList FindAnagramIndex(string text, string search)
        {
            ArrayList result = new ArrayList();
            int searchLenght = search.Length;
            int textLenght = text.Length;
            string template = String.Concat(search.OrderBy(c => c));
            for (int i = 0; i <= (textLenght-searchLenght); i++)
            {
                string pot = text.Substring(i, searchLenght);
                pot = String.Concat(pot.OrderBy(c => c));
                if (pot == search)
                {
                    result.Add(i);
                }

            }
            return result;
        }
    }
}
