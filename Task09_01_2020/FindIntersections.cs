using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTasks.Task09_01_2020
{
    public static class FindIntersections
    {
        public static int FindTreeSortArrayIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int y = 0; y < arr2.Length; y++)
                {
                    if (arr1[i] < arr2[y])
                    {
                        break;
                    }
                    if (arr1[i] == arr2[y])
                    {
                        for (int z = 0; z < arr3.Length; z++)
                        {
                            if (arr1[i] == arr3[z])
                            {
                                return arr3[z];
                            }
                        }
                    }
                }
            }
            return 0;
        }
    }
}
