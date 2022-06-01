using System;
using System.Collections.Generic;
using System.Text;

namespace ZTM_DS_Algo
{
    public class HasPairWithSum
    {
        // find pair of numbers which give the sum.
        //[1,2,3,9] sum = 8 return false as there is no pair
        //[1,2,4,4] sum = 8 return true (4,4)
        //arrays are sorted.

        //input array and sum
        //output true/false

        //naive approach form all possible pair and check for sum
        //outer loop for first number of pair
        // inner loop for second number of the pair.

        //time complexity n(n-1)/2 = O(n^2)

        //better approach

        //start two pointers in two extreme ends and take sum.
        //if sum is larger than expected move right pointer backward.
        //if sum is less than expected move left pointer forward.
        //until both the pointers meet.

        public bool DoesPairExist(int[] arr, int expected_sum) //worst case scenario sum of all the pairs is greater than expected sum.
        {
            int front_index = 0;
            int rear_index = arr.Length - 1;

            while(front_index != rear_index) //time complexity in worst case in O(n)
            {
                int sum = arr[front_index] + arr[rear_index];  //total time complexity in worst case is 4 operations.
                if(sum == expected_sum)
                {
                    return true;
                }
                else if(sum < expected_sum)
                {
                    front_index++;
                }
                else
                {
                    rear_index--;
                }

            }

            return false;
        }

        //time complexity O(n)
        //space complexity O(1)
    }
}
