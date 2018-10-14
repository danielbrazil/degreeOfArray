using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8
{
    class Result
    {

        /*
         * Complete the 'degreeOfArray' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int degreeOfArray(List<int> arr)
        {
            List<int> valueDistinct = new List<int>();
            List<int> arr2 = new List<int>();
            List<List<int>> result = new List<List<int>>();
            int iCount = 0;
            int i = 0;
            int iResult = 0;

            valueDistinct = arr.Distinct().ToList();
            
            foreach (int value in valueDistinct)
            {
                iCount = 0;
                foreach (int value2 in arr)
                {
                    if (value == value2)
                    {
                        iCount++;
                    }
                }
            }
            foreach (int value in valueDistinct)
            {
                i = 0;
                List<int> resultArray = new List<int>();

                foreach (int valueArr in arr)
                {
                    if (i <= iCount)
                    {
                        resultArray.Add(valueArr);
                        i++;
                    }
                    else
                        break;
                    
                }

                result.Add(resultArray);
                arr2.AddRange(arr);
                foreach (int valueArr in arr)
                {
                    i++;
                    if (valueArr == value)
                        arr2.RemoveAt(0);
                    else
                        break;

                }
                arr.Clear();
                arr.AddRange(arr2);
            }
            List<int> countArray = new List<int>();
            for (int j = 0; j < result.Count;j++)
            {
                countArray.Add(result[j].Count);
            }
            iResult = countArray.Min();

            return iResult;
        }

    }
}
