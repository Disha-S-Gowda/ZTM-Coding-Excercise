using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExcersize
{
    public class HashTableOperations
    {
        public void Do()
        {
            // this is a non generic data structure similar to dictionary

            Hashtable hash = new Hashtable();

            //adding to hash table
            hash.Add("Sope", "J-hope, Suga");
            hash.Add("TaeKook", "Taehyung, JungKook");
            hash.Add(7, 8);
            hash.Add("MiniMoni", "RM, Jimin");
            hash.Add("jinjin", "I am the one i should love in this world");

            this.printHashTable(hash);

            //Create Hash using dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable temp = new Hashtable(dict);

            this.printHashTable(temp);

            //Count
            Console.WriteLine(hash.Count);

            //ContainsKey
            Console.WriteLine(hash.ContainsKey("Sope"));

            //Updating
            hash[7] = "I love BTS";

            this.printHashTable(hash);

            //Access all Keys
            Console.WriteLine(hash.Keys);

            //Access all Values
            Console.WriteLine(hash.Values);


            //Remove
            hash.Remove(7);

            this.printHashTable(hash);

            //Clear
            hash.Clear();

            this.printHashTable(hash);
        }

        public void printHashTable(Hashtable hash)
        {
            foreach(DictionaryEntry entry in hash)
            {
                Console.WriteLine("Key: " + entry.Key + " Value: "+ entry.Value);
            }
            Console.WriteLine();

        }

        

    }
}
