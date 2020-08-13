using System;

namespace BasicSearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinarySearchTree.BinarySearchTree basicSearchTree = new BinarySearchTree.BinarySearchTree(4);

            basicSearchTree.AddItem(6);
            basicSearchTree.AddItem(2);
            Console.WriteLine(basicSearchTree.Contains(6));
            Console.WriteLine(basicSearchTree.DeleteItem(6));
            Console.WriteLine(basicSearchTree.Contains(6));
        }
    }
}
