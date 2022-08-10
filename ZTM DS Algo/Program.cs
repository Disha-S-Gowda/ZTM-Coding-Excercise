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

            //int[] array1 = { 0, 0, 3, 9 };
            //int sum = 0;

            //HasPairWithSum util = new HasPairWithSum();
            //bool result = util.DoesPairExist(array1, sum);
            //Console.WriteLine(result);

            //FirstReccuringElement util = new FirstReccuringElement();
            //util.Do();

            string s = "PAYPALISHIRING";
            string result = Convert(s, 3);
            Console.WriteLine(result);
        }

        public static string Convert(string s, int numRows)
        {

            string Output = "";
            for (int i = 1; i <= numRows; i++)
            {

                int endDist = numRows - i;
                int startDist = i - 1;

                Console.WriteLine(numRows+ " "+ i + " "+ endDist + " "+ startDist);
                int j = i - 1;
                bool toggle = true;
                while (j < s.Length)
                {
                    Output += s[j];

                    if (toggle && endDist != 0)
                    {
                        j += 2 * endDist;                        
                    }
                    else if (startDist != 0)
                    {
                        j += 2 * startDist;
                    }
                    else
                    {
                        j += 2 * endDist;
                    }

                    toggle = !toggle;
                    Console.WriteLine(Output);
                }
            }

            return Output;
        }
    }
}
