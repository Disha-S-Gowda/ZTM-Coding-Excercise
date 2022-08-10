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

            for (int i = 0; i < matrix.Length; i++){
                if (matrix[i][0] == 0){   isCol = true;  }

                for (int j = 1; j < matrix[0].Length; j++){
                    if (matrix[i][j] == 0)
                    {   matrix[i][0] = 0;
                        matrix[0][j] = 0;    }
                }
            }

            for (int i = 1; i < matrix.Length; i++){
                for (int j = 1; j < matrix[0].Length; j++){
                    if (matrix[i][0] == 0 || matrix[0][j] == 0){    matrix[i][j] = 0;    }
                }
            }
            if (matrix[0][0] == 0){
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    matrix[0][j] = 0;
                }
            }
            if (isCol){
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

            for (int i = 0; i < numRows; i++){
                row = new List<int>();
                for (int j = 0; j <= i; j++){

                    Console.WriteLine(i.ToString() + " " + j.ToString());
                    if (j == 0 || j == i){  row.Add(1);   }
                    else{   row.Add(pre[j - 1] + pre[j]);  }
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
            for (int i = nums.Length - 2; i >= 0; i--){
                if (nums[i] < nums[i + 1]){
                    initial = i;
                    break;
                }
            }
            if (initial != -1){
                for (int j = nums.Length - 1; j >= 0; j--){

                    if (nums[j] > nums[initial]){
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

            while (front < back){
                int temp = nums[front];
                nums[front] = nums[back];
                nums[back] = temp;
                front++;
                back--;
            }
        }


    }
}
