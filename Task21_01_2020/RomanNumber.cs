using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTasks.Task21_01_2020
{
   public static class RomanNumber
    {
        private static Dictionary<int, string> MapNumbers = new Dictionary<int, string>()
        {
            {1,"I"},
            {5,"V"},
            {10,"X"},
            {50,"L"},
            {100,"C"},
            {500,"D"},
            {1000,"M"}
        };
        public static string ConvetToRoman(int input)
        {
            StringBuilder result = new StringBuilder();
            int[] arabicNumber = new int[7];
            MapNumbers.Keys.CopyTo(arabicNumber, 0);
            for (int i = 6; i >= 0; i-=2)
            {
               
                int digit = input / arabicNumber[i];
                input = input % arabicNumber[i];
                if (i == 6)
                {
                    result.Append(ResolveArabic(digit, arabicNumber[i]));
                }
                else
                {
                    result.Append(ResolveArabic(digit, arabicNumber[i], arabicNumber[i + 1], arabicNumber[i + 2]));
                }
            }
            return result.ToString();
        }
        private static string ResolveArabic(int digit, int key)
        {
            string currentRome = MapNumbers[key];
            string result = string.Empty;
            switch (digit)
            {
                case 1: result = currentRome; break;
                case 2: result = string.Concat(currentRome, currentRome); break;
                case 3: result = string.Concat(currentRome, currentRome, currentRome); break;

            }
            return  result;
        }
        private static string ResolveArabic(int digit, int key,int key5,int key10)
        {
            string currentRome = MapNumbers[key];
            string FiveRome = string.Empty;
            string TenRome = string.Empty;
            try
            {
                FiveRome = MapNumbers[key5];
                TenRome = MapNumbers[key10];
            }
            catch (IndexOutOfRangeException ex)
            {
                FiveRome = "Error";
                TenRome = "Error";
            }
            string result = string.Empty;
            switch (digit)
            {
                case 1: result = currentRome;break;
                case 2: result = string.Concat(currentRome, currentRome);break;
                case 3: result = string.Concat(currentRome, currentRome, currentRome);break;
                case 4: result = string.Concat(currentRome, FiveRome);break;
                case 5: result = FiveRome;break;
                case 6: result = string.Concat(FiveRome, currentRome);break;
                case 7: result = string.Concat(FiveRome, currentRome,currentRome); break;
                case 8: result = string.Concat(FiveRome, currentRome,currentRome,currentRome); break;
                case 9: result = string.Concat(currentRome,TenRome); break;

            }
            return result;

        }
    }
}
