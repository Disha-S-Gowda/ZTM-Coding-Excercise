using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExcersize
{
    public class DictionaryOperations
    {
        public void Do()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            //Adding elements to dictionary
            dict.Add("Jungkook", "cutie pie");
            dict.Add("Jimin", "Duality King");
            dict.Add("Taehyung", "true Gentleman");
            dict.Add("J-hope", "All time Super handsome");
            dict.Add("Suga", "Very Mature and sooooo handsome");
            dict.Add("RM", "Someone with deep thoughts and sooo fine");
            dict.Add("Jin", "Someone who knows how to live life. visual king");
            dict.Add("Crazy girl", "BTS............................");
            this.printHashTableUsingElemntAt(dict);

            //Updating
            dict["Crazy girl"] = "I love BTS forever........";
            this.printHashTableUsingElemntAt(dict);

            //Remove
            dict.Remove("Crazy girl");
            this.printDictionary(dict);

            //Count
            Console.WriteLine(dict.Count);

            //Contains Key
            Console.WriteLine(dict.ContainsKey("Jimin"));

            //Access all keys
            foreach(string item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            //Access all Values
            foreach (string item in dict.Values)
            {
                Console.WriteLine(item);
            }


            //clear
            dict.Clear();

        }

        public void printDictionary(Dictionary<string, string> dict)
        {
            foreach(KeyValuePair<string,string> ele in dict)
            {
                Console.WriteLine("Key: " + ele.Key + " Value: " + ele.Value);
            }
            Console.WriteLine();
        }

        public void printHashTableUsingElemntAt(Dictionary<string, string> dict)
        {
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine(dict.ElementAt(i));
            }
            Console.WriteLine();
        }
    }
}
