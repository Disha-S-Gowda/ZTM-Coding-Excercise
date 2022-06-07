using System;
using System.Collections.Generic;

namespace ArrayExcersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListOperations util = new ListOperations();

            //util.Do();

            //ReverseAnArray util = new ReverseAnArray();

            //string result = util.Reverse("Hey I am Disha");
            //Console.WriteLine(result);

            //result = util.ReverseOptimised("Hey I am Disha");
            //Console.WriteLine(result);

            MergeSortedArrays util = new MergeSortedArrays();
            List<int> l1 = new List<int>() { 0, 3, 4, 31 };
            List<int> l2 = new List<int>() { 4, 6, 30 };
            List<int> result = util.merge(l1, l2);
            util.PrintList(result);


        }
    }
}
