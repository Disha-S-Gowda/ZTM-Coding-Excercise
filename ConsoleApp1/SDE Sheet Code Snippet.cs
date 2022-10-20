using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExcersize
{
    internal class SDE_Sheet_Code_Snippet
    {

        /*
         Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.

            Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
            Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]

            A straightforward solution using O(mn) space is probably a bad idea.
            A simple improvement uses O(m + n) space, but still not the best solution.
            Could you devise a constant space solution?
         */

        public void SetZeroes(int[][] matrix)
        {
            bool isCol = false;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0) { isCol = true; }

                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0) { matrix[i][j] = 0; }
                }
            }
            if (matrix[0][0] == 0)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    matrix[0][j] = 0;
                }
            }
            if (isCol)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }

        /*
         In Pascal's triangle, each number is the sum of the two numbers directly above it.
         Given an integer numRows, return the first numRows of Pascal's triangle.

        Input: numRows = 5
        Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
        Example 2:
         */

        public IList<IList<int>> Generate(int numRows)
        {
            List<int> pre, row = null;
            pre = new List<int>();
            List<IList<int>> output = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                row = new List<int>();
                for (int j = 0; j <= i; j++)
                {

                    Console.WriteLine(i.ToString() + " " + j.ToString());
                    if (j == 0 || j == i) { row.Add(1); }
                    else { row.Add(pre[j - 1] + pre[j]); }
                }
                pre = row;
                output.Add(row);
            }
            return output;
        }

        /*
           if all the permutations of the array are sorted in one container according to their lexicographical order,
           then the next permutation of that array is the permutation that follows it in the sorted container.
          
            For example, the next permutation of arr = [1,2,3] is [1,3,2].
            Similarly, the next permutation of arr = [2,3,1] is [3,1,2].
            While the next permutation of arr = [3,2,1] is [1,2,3] because [3,2,1] does not have a lexicographical larger rearrangement.
         */

        public void NextPermutation(int[] nums)
        {
            int initial = -1, end = -1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] < nums[i + 1])
                {
                    initial = i;
                    break;
                }
            }
            if (initial != -1)
            {
                for (int j = nums.Length - 1; j >= 0; j--)
                {

                    if (nums[j] > nums[initial])
                    {
                        end = j;
                        break;
                    }
                }
                int temp = nums[initial];
                nums[initial] = nums[end];
                nums[end] = temp;
            }
            int front = initial + 1;
            int back = nums.Length - 1;

            while (front < back)
            {
                int temp = nums[front];
                nums[front] = nums[back];
                nums[back] = temp;
                front++;
                back--;
            }
        }

        /*  Maximum Subarray

        Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

        Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        Output: 6
        Explanation: [4,-1,2,1] has the largest sum = 6.

        Input: nums = [5,4,-1,7,8]
        Output: 23
         
        */

        public int MaxSubArray(int[] nums)
        {

            int sum = 0;
            int maxSum = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                maxSum = (sum > maxSum) ? sum : maxSum;
                sum = (sum > 0) ? sum : 0;

            }
            return maxSum;
        }

        /* Merge Sorted Array
         
            You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, 
            and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
            Merge nums1 and nums2 into a single array sorted in non-decreasing order.

            Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
            Output: [1,2,2,3,5,6]
            Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
            The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.

            Input: nums1 = [0], m = 0, nums2 = [1], n = 1
            Output: [1]
            Explanation: The arrays we are merging are [] and [1].
            The result of the merge is [1].
        */

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int k = m + n - 1;
            m--;
            n--;

            while (n > -1 && m > -1)
            {

                if (nums1[m] > nums2[n])
                {
                    nums1[k] = nums1[m];
                    m--;
                }
                else
                {
                    nums1[k] = nums2[n];
                    n--;
                }
                k--;
            }
            while (n > -1)
            {
                nums1[k] = nums2[n];
                k--;
                n--;
            }

        }

        /* First Bad Version
            Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one,
            which causes all the following ones to be bad.

            You are given an API bool isBadVersion(version) which returns whether version is bad.
            Implement a function to find the first bad version. You should minimize the number of calls to the API.

            Input: n = 5, bad = 4
            Output: 4
            Explanation:
            call isBadVersion(3) -> false
            call isBadVersion(5) -> true
            call isBadVersion(4) -> true
            Then 4 is the first bad version.

        Input: n = 1, bad = 1
        Output: 1
        */

        public int FirstBadVersion(int n)
        {

            int left = 1;
            int right = n;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        private bool IsBadVersion(int mid)
        {
            throw new NotImplementedException();
        }

        /*  Climbing Stairs
            You are climbing a staircase. It takes n steps to reach the top.
            Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

            Input: n = 2
            Output: 2
            Explanation: There are two ways to climb to the top.
            1. 1 step + 1 step
            2. 2 steps

            Input: n = 3
            Output: 3
            Explanation: There are three ways to climb to the top.
            1. 1 step + 1 step + 1 step
            2. 1 step + 2 steps
            3. 2 steps + 1 step
        */

        public int ClimbStairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            int x = 1, y = 2;
            for (int i = 3; i < n; i++)
            {
                int temp = y;
                y += x;
                x = temp;
                //Console.WriteLine(i + " "+ x + " " + y);
            }
            return x + y;
        }

        /* Rotate Image
         
        You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
        You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. 
        DO NOT allocate another 2D matrix and do the rotation.

        Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
        Output: [[7,4,1],[8,5,2],[9,6,3]]

        Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
        Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
         
        */

        public void Rotate(int[][] matrix)
        {

            int n = matrix.Length;

            for (int i = 0; i < n / 2 + n % 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {

                    int temp = matrix[n - 1 - j][i];
                    matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j];
                    matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i];
                    matrix[j][n - 1 - i] = matrix[i][j];
                    matrix[i][j] = temp;
                }
            }
        }

        /*  Merge Intervals
         Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
         Output: [[1,6],[8,10],[15,18]]
         Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].

        Input: intervals = [[1,4],[0,2],[3,5]]
        Output: [[0,5]]

         */

        public int[][] Merge(int[][] intervals)
        {

            int[][] output = new int[intervals.Length][];
            int k = 0;

            for (int i = 0; i < intervals.Length - 1; i++)
            {

                if (intervals[i][1] >= intervals[i + 1][0])
                {

                    output[k][0] = intervals[i][0];
                    output[k][1] = intervals[i + 1][1];
                    i++;
                    k++;
                }
                else
                {
                    output[k][0] = intervals[i][0];
                    output[k][1] = intervals[i][1];
                    k++;
                }
            }
            return output;
        }

        /*  Find the Duplicate Number
         
        Input: nums = [1,3,4,2,2]
        Output: 2

        Input: nums = [3,1,3,4,2]
        Output: 3

         */

        public int FindDuplicate(int[] nums)
        {

            int slow_pointer = nums[0];
            int fast_pointer = nums[0];
            Console.WriteLine("slow " + slow_pointer + " fast " + fast_pointer);
            do
            {

                slow_pointer = nums[slow_pointer];
                fast_pointer = nums[nums[fast_pointer]];

                Console.WriteLine("slow " + slow_pointer + " fast " + fast_pointer);
            } while (slow_pointer != fast_pointer);

            slow_pointer = nums[0];

            Console.WriteLine("Phase 2 --slow " + slow_pointer + " fast " + fast_pointer);
            while (slow_pointer != fast_pointer)
            {
                slow_pointer = nums[slow_pointer];
                fast_pointer = nums[fast_pointer];

                Console.WriteLine("slow " + slow_pointer + " fast " + fast_pointer);
            }

            return slow_pointer;

        }

        /* Pow(x, n)
         
        Implement pow(x, n), which calculates x raised to the power n (i.e., x^n).

         */

        public double MyPow(double x, int n)
        {

            double product = 1;
            long nn = n; // Long is larger than double. it will take care of the owerflow when -n is converted to +n;

            if (nn < 0) nn = -1 * nn; //convert -ve n to positive

            while (nn > 0)
            {

                //if power is odd x^n = x * x^(n-1)
                if (nn % 2 != 0)
                {
                    product *= x;
                    nn--;
                }
                else
                {

                    //if power is even x^n = (x * x)^(n/2)
                    x = x * x;
                    nn = nn / 2;
                }

            }

            if (n < 0)
            {
                product = (double)1 / (double)product;
            }

            return product;
        }

        /* Majority Element
         
        Given an array nums of size n, return the majority element.
        The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
        
        Input: nums = [2,2,1,1,1,2,2]
        Output: 2
        */

        public int MajorityElement(int[] nums)
        {
            //Moore's Voting Algorithm

            //since problem states the mejority element is present more than n/2 times. 
            //even if we cancel the count whenever we encounter non majority element the element             //which remains in the last with count more than 0 will be the majority element.

            //Apply Moore's Algo
            int num = -1;
            int count = 0;

            foreach (int ele in nums)
            {

                if (count == 0)
                {
                    num = ele;
                }

                if (num == ele)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            //we can confidently return the number since we know 
            //there is always a majority element present

            return num;
        }

        /* Majority Element II
         
        Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.

        Input: nums = [3,2,3]
        Output: [3]

        Input: nums = [2,1,1,3,1,4,5,6]
        Output: [1]

         */

        public IList<int> MajorityElement2(int[] nums)
        {

            //Moore's Voting Algorithm

            //since problem states the mejority element is present more than n/2 times. 
            //even if we cancel the count whenever we encounter non majority element the element             //which remains in the last with count more than 0 will be the majority element.

            //Apply Moore's Algo
            int num1 = -1;
            int num2 = -1;
            int count1 = 0;
            int count2 = 0;
            //since the count has to be more than n/3. we can have max 2 majority elements

            foreach (int ele in nums)
            {

                if (num1 == ele)
                {
                    count1++;
                }
                else if (num2 == ele)
                {
                    count2++;
                }
                else if (count1 == 0)
                {
                    num1 = ele;
                    count1++;
                }
                else if (count2 == 0)
                {
                    num2 = ele;
                    count2++;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            count1 = 0;
            count2 = 0;

            //after algo execution make sure the majority element are correct.
            foreach (int ele in nums)
            {
                if (num1 == ele)
                {
                    count1++;
                }
                else if (num2 == ele)
                {
                    count2++;
                }
            }

            List<int> output = new List<int>();
            int limit = nums.Length / 3;

            if (count1 > limit)
            {
                output.Add(num1);
            }
            if (count2 > limit)
            {
                output.Add(num2);
            }
            return output;
        }
    }
}
