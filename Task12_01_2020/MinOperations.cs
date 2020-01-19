using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTasks.Task12_01_2020
{
    public static class MinOperations
    {
        public static int NumberOfOperations(int start, int end)
        {
            int result = 0;
            int currentNumber = end;
            ThrowExceptions(start, end);
            while (currentNumber > start)
            {
                currentNumber = currentNumber / 2;
                result++;
            }
            result = result + (start - currentNumber);
            return result;
        }

        private static void ThrowExceptions(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException(String.Format("Start Number has to be greater than end number.Start {0}; End {1}", start, end));
            }
            if (end % 2 == 1)
            {
                throw new ArgumentException(String.Format("End number has to be even. End {0}", end));
            }
        }
    }
}
