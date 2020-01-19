using InterviewTasks.Task14_01_2020;
using InterviewTasks.Task18_01_2020;
using System;

namespace InterviewTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
           // CallSumBinary();
        }

        private static void PascalTriangleRow()
        {
            int row = 0;
            Console.WriteLine("Enter row number:");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("Result is {0}", PascalTriangle.PascalTriangleRow(row)));

        }
        private static void CallSumBinary()
        {
            string first = string.Empty;
            string second = string.Empty;
            Console.WriteLine("Enter First Number:");
            first=Console.ReadLine();
            Console.WriteLine("Enter Second Number:");
            second = Console.ReadLine();

            SumBinary task = new SumBinary(first, second);

            Console.WriteLine(String.Format("Result is {0}", task.ReturnResult()));
        }
    }
}
