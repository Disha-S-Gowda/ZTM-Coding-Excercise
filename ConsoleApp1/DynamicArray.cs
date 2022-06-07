using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayExcersize
{
    public class DynamicArray
    {

        public void Do()
        {
            ArrayList resultList = new ArrayList();

            //Adding to ArrayList
            resultList.Add("Sandeep");
            resultList.Add("Sanjay");
            resultList.Add("Suhana");
            resultList.Add("Arun");

            printArray(resultList);

            //removing an element
            resultList.Remove("Arun");

            printArray(resultList);

            //removing at a position
            resultList.RemoveAt(0);

            printArray(resultList);

            //insert
            resultList.Insert(2, "inserting");

            printArray(resultList);

            //inserting new array
            ArrayList arr2 = new ArrayList() { "a" , "b", "c"};

            resultList.InsertRange(2, arr2);

            printArray(resultList);

            //Sorting
            resultList.Sort();
            printArray(resultList);

            //Length of array
            var len = resultList.Count;
            Console.WriteLine(len);


        }

        void printArray(ArrayList array)
        {
            foreach(string ele in array)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
        }
    }
}
