using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesExcersize
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if(this.root == null)  {  this.root = newNode;  }
            else
            {   Node currentNode = this.root;
                while (true)
                {   if(value < currentNode.value)
                    {   if (currentNode.left == null)
                        {   currentNode.left = newNode;
                            return;   }
                        else
                        {   currentNode = currentNode.left;   }
                    }
                    else
                    {   if( currentNode.right == null)
                        {   currentNode.right = newNode;
                            return;  }
                        else
                        {  currentNode = currentNode.right;   }
                    }
                }
            }
        }

        public Node Lookup(int value)
        {   Node currentNode = this.root;
            while(currentNode != null)
            {
                if(value < currentNode.value)
                {   currentNode = currentNode.left;  }
                else if(value > currentNode.value)
                {   currentNode = currentNode.right; }
                else if(value == currentNode.value)
                {   return currentNode;  }                
            }
            return null;
        }

        public Node Delete(Node root, int data)
        {
            if(root == null) { return root; }

            if(data < root.value)
            {
                root.left = Delete(root.left, data);
            }
            else if(data > root.value)
            {
                root.right = Delete(root.right, data);
            }
            else
            {
                //1. No children
                if (root.left == null && root.right == null)
                {
                    return null;
                }
                //Only one Child
                else if (root.left == null)
                {
                    return root.right;
                }
                else if (root.right == null)
                {
                    return root.left;
                }
                else
                {
                    Node temp = FindMin(root.right);
                    root.value = temp.value;
                    root.right = Delete(root.right, temp.value);
                }
            }
            return root;
            
        }

        public Node FindMin(Node root)
        {
            int min = root.value;
            Node minNode = root;
            while(root != null)
            {
                if(root.left != null && root.left.value < min)
                {
                    minNode = root.left; 
                    min = root.left.value;
                }
                else if(root.right != null)
                {
                    root = root.right;
                }                
                root = root.left;
            }
            return minNode;
        }

        public void traverse(Node node)
        {
           // var tree = new Node(node.value)
           Console.WriteLine(JsonConvert.SerializeObject(node,Formatting.Indented));

        }

        public void Do()
        {
            this.Insert(9);
            this.Insert(4);
            this.Insert(6);
            this.Insert(20);
            this.Insert(170);
            this.Insert(15);
            this.Insert(1);
            Console.WriteLine(this.Lookup(909)?.value);
            this.Delete(this.root, 20);
            this.traverse(this.root);

        }
    }

    public class Node
    {
        public int value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }

        public Node(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
