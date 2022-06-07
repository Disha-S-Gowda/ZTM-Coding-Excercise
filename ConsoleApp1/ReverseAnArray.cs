using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExcersize
{
    public class ReverseAnArray
    {
       
        public ReverseAnArray()
        {
            
        }

        public string Reverse(string str)
        {

            //check input
            if(string.IsNullOrEmpty(str) || str.Length < 2)
            {
                return str;
            }

            //reverse string
            int count = 0; //O(n)
            char[] input = str.ToCharArray();
            char[] output = new char[input.Length];
            int j = 0;
            for(int i = input.Length - 1; i >= 0; i--)
            {                
                output[j] = input[i];
                j++;

                count++;

            }     
            Console.WriteLine("Iteration Count = " + count);
            return new string(output);  
        }

        public string ReverseOptimised(string str)
        {
            //check input
            if(string.IsNullOrEmpty(str) || str.Length < 2)
            {
                return str;
            }

            //reverse string
            int count = 0; // O(n/2) = O(n)
            char[] input = str.ToCharArray();
            int j = 0;
            int i = input.Length - 1;

            while(i > j)
            {
                char temp = input[i];
                input[i] = input[j];
                input[j] = temp;
                j++;
                i--;

                count++;
            }
            Console.WriteLine("Iteration Count = " + count);
            return new string(input);
        }
    }
}
