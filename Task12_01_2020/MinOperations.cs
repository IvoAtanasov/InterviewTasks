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
            int algo1 = 0;
            int algo2 = 0;

            ThrowExceptions(start, end);
            try
            {
                algo1 = AlgoDivisionDeduction(start, end);
            }
            catch (ArgumentException ex)
            {
                return AlgoDeductionMultiPly(start, end);
            }
            algo2 = AlgoDeductionMultiPly(start, end);
            if (algo1 < algo2)
            {
                result = algo1;
            }
            else
            {
                result = algo2;
            }
            return result;
        }

        private static int AlgoDivisionDeduction(int start, int currentNumber)
        {
            int result = 0;
            while (currentNumber > start)
            {
                if (currentNumber % 2 == 1)
                {
                    throw new ArgumentException("No possible solution");
                }
                currentNumber = currentNumber / 2;
                result++;
            }
            result = result + (start - currentNumber);
            return result;
        }

        private static int AlgoDeductionMultiPly(int start, int end)
        {
            int result = 0;
            while (start < end)
            {
                start = start * 2;
                result++;
            }
            result = result + (start - end);
            return result;
        }

        private static void ThrowExceptions(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException(String.Format("Start Number has to be greater than end number.Start {0}; End {1}", start, end));
            }
        }
    }
}
