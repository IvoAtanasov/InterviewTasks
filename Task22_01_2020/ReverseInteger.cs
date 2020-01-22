using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTasks.Task22_01_2020
{
     public static class ReverseInteger
    {
        public static int Reverse(int input)
        {
            int result = 0;
            int remainder = 0;
            while (input != 0)
            {
                remainder = input % 10;
                result = result * 10 + remainder;
                input = input / 10;
            }
            return result;
        }

    }
}
