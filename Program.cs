using InterviewTasks.Task12_01_2020;
using InterviewTasks.Task14_01_2020;
using InterviewTasks.Task18_01_2020;
using InterviewTasks.Task21_01_2020;
using InterviewTasks.Task22_01_2020;
using System;

namespace InterviewTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // CallSumBinary();
            //PascalTriangleRow();
            string repeat = "y";
            while (repeat != "n")
            {
                try
                {
                    //NumberOfOperations();
                    //ReverseNumber();
                    //test checkin
                   ConvertToRomeNumber();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Handled exception: " + ex.Message);
                }
                Console.WriteLine("Continue Y/N:");
                repeat = Console.ReadLine().ToLower();
            }
        }

        private static void ConvertToRomeNumber()
        {
            int number = 0;
            Console.WriteLine("Enter a number to convert to rome:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("Result is {0}", RomanNumber.ConvetToRoman(number)));
        }
        private static void ReverseNumber()
        {
            int number = 0;
            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("Result is {0}", ReverseInteger.Reverse(number)));
        }
        private static void NumberOfOperations()
        {
            int first = 0;
            int second = 0;
            Console.WriteLine("Enter First Number:");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("Result is {0}", MinOperations.NumberOfOperations(first,second)));
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
