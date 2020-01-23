using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTasks.Task21_01_2020
{
   public static class RomanNumber
    {
        private Dictionary<string, int> MapNumbers = new Dictionary<string, int>()
        {
            {"I",1},
            {"V",5},
            {"X",10},
            {"L",50},
            {"C",100},
            {"D",500},
            {"M",1000}
        };
        public static string ConvetToRoman(int input)
        {
            StringBuilder result = new StringBuilder();

            return result.ToString();
        }
    }
}
