using System;

namespace ZTM_DS_Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //given 2 arrays, create a function that let's a user know (true/false)
            //char[] array1 = { 'a', 'x', 'c', 'x'};
            //char[] array2 = { 'z', 'z', 'x' };

            //GoogleInterviewExcercise util = new GoogleInterviewExcercise();

            //var result = util.FindCommonItem(array1, array2);
            //Console.WriteLine(result);

            int[] array1 = { 0, 0, 3, 9 };
            int sum = 0;

            HasPairWithSum util = new HasPairWithSum();
            bool result = util.DoesPairExist(array1, sum);
            Console.WriteLine(result);
        }
    }
}
