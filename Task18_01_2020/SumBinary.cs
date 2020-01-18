using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTasks.Task18_01_2020
{
    public class SumBinary
    {
        private string FirstNumber { get; set; }
        private string SecondNumber { get; set; }

        public SumBinary(string firstNumber, string secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public string ReturnResult()
        {
            StringBuilder result = new StringBuilder();
            bool oneInMind = false;
            int firstLenght = FirstNumber.Length;
            int secondLenght = SecondNumber.Length;
            int loopEnd = 0;

            if (firstLenght > secondLenght)
            {
                loopEnd = firstLenght;
                SecondNumber = LeadingZeros(firstLenght - secondLenght) + SecondNumber;
            }
            else
            {
                loopEnd = secondLenght;
                FirstNumber = LeadingZeros(secondLenght - firstLenght) + FirstNumber;
            }
            for (int i = 0; i < loopEnd; i++)
            {

            }
            return result.ToString();
        }

        private string LeadingZeros(int numberOfZeos)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numberOfZeos; i++)
            {
                result.Append("0");
            }
            return result.ToString();
        }
    }
}
