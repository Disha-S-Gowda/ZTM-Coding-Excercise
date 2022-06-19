using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode_array
{
    internal class Combination
    {
        public Combination()
        {
            Console.WriteLine("Print Combination execution started");

            List<int[]> temp = new List<int[]>();
            int[] arr = { 1, 2, 3, 4, 5 };

            temp.Add(arr);
            foreach (int[] item in temp)
            {
                foreach (int ele in item)
                {
                    Console.Write(ele + " ");
                }
                Console.WriteLine();
            }
            int r = 3;
            int n = arr.Length;
            //this.PrintCombination(arr, n, r);
        }

        // Print combinations of r elements in an array of size n

        List<int[]> Answers = new List<int[]>();

        public void PrintCombination(int[] arr, int n, int r)
        {
            //temporary array for the combination
            int[] data = new int[r];

            CombinationUtil(arr, data, 0, n - 1, 0, r);

            //foreach (int[] item in Answers)
            //{
            //    foreach (int ele in item)
            //    {
            //        Console.Write(ele + " ");
            //    }
            //    Console.WriteLine();
            //}

        }

        /* arr[] ---> Input Array 
        data[] ---> Temporary array to 
        store current combination 
        start & end ---> Staring and 
        Ending indexes in arr[] 
        index ---> Current index in data[] 
        r ---> Size of a combination to be printed */
        public void CombinationUtil(int[] arr, int[] data,int start, int end, int index, int r)
        {
            // Current combination is ready (base case)
            // to be printed, print it 
            if (index == r)
            {
                foreach (int ele in data)
                {
                    Console.Write(ele + " ");
                }
                Console.WriteLine();
                this.Answers.Add(data);
                return;
            }

            // replace index with all possible 
            // elements. The condition "end-i+1 >= r-index" 
            // makes sure that including one element 
            // at index will make a combination with 
            // remaining elements at remaining positions 

            for(int i = start; i <= end && end - i + 1 >= r - index; i++)
            {
                //data.Insert(index, arr[i]);
                data[index] = arr[i];
                CombinationUtil(arr, data, i + 1, end, index + 1, r);
            }


        }

        //public class Solution
        //{

        //    public IList<IList<int>> ThreeSum(int[] nums)
        //    {

        //        List<List<int>> ans = new List<List<int>>();
        //        List<int> data = new List<int>();

        //        GenerateTriplet(nums, data, ans, 0, nums.Length - 1, 0, 3);

        //        Console.WriteLine("printing ans");
        //        foreach (List<int> ele in ans)
        //        {
        //            foreach (int item in ele)
        //            {
        //                Console.Write(item + " ");
        //            }
        //            Console.WriteLine();
        //        }

        //        return ans as IList<IList<int>>;

        //    }

        //    public void GenerateTriplet(int[] nums, List<int> data, List<List<int>> ans, int start, int end, int index, int r)
        //    {

        //        if (index == r)
        //        {

        //            Console.WriteLine(index + "  " + r + " data sum" + data.Sum());

        //            foreach (int item in data)
        //            {
        //                Console.Write(item + " ");
        //            }
        //            Console.WriteLine();

        //            if (data.Sum() == 0)
        //            {
        //                Console.WriteLine("data entered");
        //                ans.Add(data);
        //            }
        //        }

        //        for (int i = start; i <= end && end - i + 1 >= r - index; i++)
        //        {

        //            data.Add(nums[i]);
        //            GenerateTriplet(nums, data, ans, i + 1, end, index + 1, r);
        //            data.Remove(nums[i]);
        //        }
        //    }
        //}
    }
}
