using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTasks.Task14_01_2020
{
    public static class PascalTriangle
    {
        public static string PascalTriangleRow(int row)
        {
            string result = string.Empty;
            List<int> previousArr = new List<int>();
            for(int rowlen = 1; rowlen < row; rowlen++)
            {
                int[] potArr = new int[rowlen];
                if (previousArr.Count == 0)
                {
                    potArr[0] = 1;
                }
                potArr = ReturnArr(previousArr);
                if (row == rowlen)
                {
                    result = string.Join(",", potArr);
                }
                previousArr.Clear();
                previousArr.AddRange(potArr);

            }
            return result;
        }

        private static int[] ReturnArr(List<int> previousArr)
        {
            int[] result = new int[previousArr.Count+1];
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0 || i == result.Length - 1)
                {
                    result[i] = 1;
                }
                result[i] = previousArr[i - 1] + previousArr[i];
            }
            return result;
        }
    }
}
