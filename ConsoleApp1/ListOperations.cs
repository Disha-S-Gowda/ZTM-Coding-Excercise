using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExcersize
{
    internal class ListOperations
    {
        public void Do()
        {
            List<int> list = new List<int>();

            //addition

            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            PrintList(list);

            //updation
            list[0] = 12;
            list[1] = 13;
            PrintList(list);

            //intsertion at specific index
            list.Insert(0, 99);
            list.Insert(0, 98);
            PrintList(list);

            //insert Range
            int[] range = { 9, 7, 5 };
            list.InsertRange(5, range);
            PrintList(list);

            //Remove
            list.RemoveAt(0);
            PrintList(list);

            list.Remove(99);
            PrintList(list);

            list.RemoveRange(1, 2);
            PrintList(list);

            //sorting

            list.Sort();
            PrintList(list);

            //Reversing
            list.Reverse();
            PrintList(list);

            //Searching
            var temp = list.IndexOf(5);
            Console.WriteLine(temp);

            //BinarySearching
            var temp1 = list.BinarySearch(7);
            Console.WriteLine(temp1);
        }

        void PrintList(List<int> list)
        {
            foreach(int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
