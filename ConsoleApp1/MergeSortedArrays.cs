using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayExcersize
{
    internal class MergeSortedArrays
    {
        public List<int> merge(List<int> array1, List<int> array2)
        {
            List<int> mergedArray = new List<int>();
            int i = 0;
            int j = 0;
            int k = 0;

            //merging both arrays
            while (i < array1.Count && j < array2.Count)
            {
                if(array1[i] <= array2[j])
                {
                    mergedArray.Add(array1[i]);
                    i++;
                }
                else
                {
                    mergedArray.Add(array2[j]);
                    j++;
                }
                k++;
            }

            //copying remaining arrays
            while(i < array1.Count)
            {
                mergedArray.Add(array1[i]);
                i++; k++;
            }
            while(j < array2.Count)
            {
                mergedArray.Add(array2[j]);
                j++;
                k++;
            }

            return mergedArray;
        }

        public void PrintList(List<int> inputList)
        {
            foreach(int item in inputList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
