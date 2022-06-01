using System;
using System.Collections.Generic;
using System.Text;

namespace ZTM_DS_Algo
{
    public class GoogleInterviewExcercise
    {
        /* given 2 arrays, create a function that let's a user know (true/false)
         * whether these two arrayscontain any common items
         * 
         * for example:
         * Const array1 = ['a','b','c','x'];
         * Const array2 = ['z', 'z', 'i'];
         * should return false
         * 
         * Const array1 = ['a','b','c','x'];
         * Const array2 = ['z', 'z', 'x'];
         * should return true
         * 
         * most important: time complexity.
         * 
         * bruteforce: loop through first array
                        for each item loop through 2nd array

        Complexity O(a * b)

        Better approach:

        loop though first array and create a hash map.

        loop though second array and for each element 
        look up in the hash map if it is present or not.
         */

        public bool FindCommonItem(char[] arr1, char[] arr2)
        {
            //loop though first array and create a hash map.
            Dictionary<char, bool> map = new Dictionary<char, bool>();

            for(int i= 0; i< arr1.Length; i++)
            {
                var item = arr1[i];

                if (!map.ContainsKey(item))
                {
                    map.Add(item, true);
                }
               
            }

            //loop though second array and for each element
            //look up in the hash map if it is present or not.

            for(int j = 0; j < arr2.Length; j++){

                if (map.ContainsKey(arr2[j]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
