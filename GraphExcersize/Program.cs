using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace GraphExcersize
{
    class Result
    {

        /*
         * Complete the 'kSub' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY nums
         */

        public static long kSub(int k, List<int> nums)
        {
            int ans = 0;
            long temp = 0;

            int[] mp = new int[2 * k];
            Array.Fill(mp, 0);
            mp[0] = 1;
            foreach (int i in nums)
            {
                temp += i;
                long kl = (long)(int)k;
                int rem = Convert.ToInt32(temp % kl);
                if (rem < 0) rem = (rem + k) % k; // if remainder is -ve we are making it +ve
                ans += mp[rem];
                mp[rem]++;

            }

            return ans;
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput());

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            int numsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> nums = new List<int>();

            for (int i = 0; i < numsCount; i++)
            {
                int numsItem = Convert.ToInt32(Console.ReadLine().Trim());
                nums.Add(numsItem);
            }

            long result = Result.kSub(k, nums);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
