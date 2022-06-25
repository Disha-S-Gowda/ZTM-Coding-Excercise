using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExcercize
{
    internal class LinkedListOperations
    {
        public void Do()
        {
            LinkedList<string> list = new LinkedList<string>();

            //Add first
            list.AddFirst("one");
            list.AddFirst("two");
            list.AddFirst("three");
            list.AddFirst("four");

            this.PrintList(list);

            //add last
            list.AddLast("apple");
            list.AddLast("grapes");

            this.PrintList(list);

            //Find element
            LinkedListNode<string> ele = list.Find("apple");
            Console.WriteLine(ele.Value);

            //add before
            list.AddBefore(ele, "interval");

            this.PrintList(list);

            //add after
            list.AddAfter(ele, "watermelon");

            this.PrintList(list);

            //remove
            list.RemoveFirst();

            this.PrintList(list);

            list.RemoveLast();

            this.PrintList(list);

            list.Remove("interval");

            this.PrintList(list);

            //list count
            Console.WriteLine(list.Count);

            //contains

            Console.WriteLine(list.Contains("one"));


            //access first and last node.
            LinkedListNode<string> head = list.First;
            Console.WriteLine(head.Value);

            LinkedListNode<string> tail = list.Last;
            Console.WriteLine(tail.Value);

            this.PrintListinReverse(list);
        }

        public void PrintList(LinkedList<string> list)
        {
            LinkedListNode<string> node = list.First;

            while(node != null)
            {
                Console.Write(node.Value + " ");
                node = node.Next;
            }
            Console.WriteLine();
        }

        public void PrintListinReverse(LinkedList<string> list)
        {
            LinkedListNode<string> node = list.Last;

            while(node != null)
            {
                Console.Write(node.Value + " ");
                node = node.Previous;
            }
            Console.WriteLine();
        }
    }
}
