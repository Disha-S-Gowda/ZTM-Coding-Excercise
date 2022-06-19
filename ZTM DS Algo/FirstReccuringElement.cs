using System;
using System.Collections.Generic;
using System.Text;

namespace ZTM_DS_Algo
{
    internal class FirstReccuringElement
    {
        public void Do()
        {
            List<int> list = new List<int>() { 2,5,5,2,3,7,8,4,9};

            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int result = this.FindRecurring(list);

            Console.WriteLine(result);
        }

        public int FindRecurring(List<int> list)
        {
            HashSet<int> hash = new HashSet<int>();

            foreach(int item in list)
            {
                if (!hash.Add(item))
                {
                    return item;
                }
            }
            return -1;
        }
    }
}
