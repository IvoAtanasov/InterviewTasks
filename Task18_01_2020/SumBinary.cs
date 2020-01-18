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
            int loopEnd = SetLoopEnd(firstLenght, secondLenght);

            for (int i = loopEnd - 1; i >= 0; i--)
            {
                int currentSum = int.Parse(FirstNumber[i].ToString()) + int.Parse(SecondNumber[i].ToString());
                if (oneInMind)
                {
                    currentSum += 1;
                }
                oneInMind = false;
                switch (currentSum)
                {
                    case 0: result.Append("0"); break;
                    case 1: result.Append("1"); break;
                    case 2: result.Append("0"); oneInMind = true; break;
                    case 3: result.Append("1"); oneInMind = true; break;
                    default: throw new ArgumentException("Inccorrect operation");
                }
            }
            if (oneInMind)
            {
                result.Append("1");
            }
            return ReverseString(result.ToString());
        }

        private int SetLoopEnd(int firstLenght, int secondLenght)
        {
            int loopEnd;
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

            return loopEnd;
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

        private string ReverseString(string input)
        {
            StringBuilder result = new StringBuilder();
            int strlen = input.Length;
            for (int i = 0; i < strlen; i++)
            {
                result.Append(input[strlen - 1 - i]);
            }
            return result.ToString();
        }
    }
}
