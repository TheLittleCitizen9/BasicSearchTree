using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Xml.Schema;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public BSTNode Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public BinarySearchTree(int value)
        {
            Root = new BSTNode(value);
        }

        public BinarySearchTree(BSTNode root)
        {
            Root = root;
        }

        public int GetMax()
        {
            if(Root == null)
            {
                return -1;
            }
            return Root.Max();
        }

        public int GetMin()
        {
            if (Root == null)
            {
                return -1;
            }
            return Root.Min();
        }

        public bool AddItem(int value)
        {
            BSTNode newNode = new BSTNode(value);
            BSTNode tempParent;
            var currentNode = Root;
            if(Root == null)
            {
                Root = newNode;
                return true;
            }
            while (true)
            {
                tempParent = currentNode;
                if (value < Root.Value)
                {
                    currentNode = currentNode.Left;
                    if(currentNode == null)
                    {
                        tempParent.Left = newNode;
                        return true;
                    }
                }
                else if(value > Root.Value)
                {
                    currentNode = currentNode.Right;
                    if(currentNode == null)
                    {
                        tempParent.Right = newNode;
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Contains(int value)
        {
            return FindItem(value) != null;
        }

        public BSTNode FindItem(int value)
        {
            if (Root == null)
            {
                return null;
            }
            return Root.FindItem(value);
        }

        public bool DeleteItem(int value)
        {
            throw new System.NotImplementedException();
        }

        private void OrderBst()
        {
            throw new System.NotImplementedException();
        }

        private BSTNode SortedArrayToBST(int[] array, int start, int end)
        {
            throw new System.NotImplementedException();
        }

        private IEnumerable<int> Scan(BSTNode node)
        {
            throw new System.NotImplementedException();
        }
    }
}
