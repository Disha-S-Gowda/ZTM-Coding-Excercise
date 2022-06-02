using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExcersize
{
    public class StaticArrays
    {
        public void Do()
        {
            int[] array = new int[6];

            //Addition
            array[0] = 2;
            array[1] = 3;
            array[2] = 4;
            array[3] = 5;

            printArray(array);

            //removal
            array[1] = 0;

            printArray(array);

            //finding length
            Console.WriteLine(array.Length);

            //updating array
            array[2] = -1;
            printArray(array);

            //Sorting Array
            Array.Sort(array);
            Console.WriteLine("Sorting....");
            printArray(array);

            //reversing array
            Array.Reverse(array);
            Console.WriteLine("Reverse....");
            printArray(array);



        }

        //printing array
        void printArray(int[] arr)
        {
            foreach(int ele in arr)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();            
        }
    }
}
