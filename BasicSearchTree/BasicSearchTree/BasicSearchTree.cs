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
            if(Root == null)
            {
                Root = newNode;
                return true;
            }

            BSTNode tempParent;
            var currentNode = Root;
            while (true)
            {
                tempParent = currentNode;
                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                    if (currentNode == null)
                    {
                        return tempParent.AddItem(value);
                    }
                }
                else if (value > currentNode.Value)
                {
                    currentNode = currentNode.Right;
                    if (currentNode == null)
                    {
                        return tempParent.AddItem(value);
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

            var current = Root;

            BSTNode rRes = null;
            BSTNode lRes = null;
            if (current.Value == value)
            {
                return current;
            }
            if (current.Left == null && current.Right == null)
            {
                return null;
            }
            if(current.FindItem(value) != null)
            {
                return current.FindItem(value);
            }
            rRes = current.FindItem(current.Right.Value);
            lRes = current.FindItem(current.Left.Value);
            if(rRes != null)
            {
                return rRes;
            }
            else
            {
                return lRes;
            }
        }

        public bool DeleteItem(int value)
        {
            var parent = GetParent(value);
            return Root.DeleteItem(value, parent);
        }

        private BSTNode GetParent(int value)
        {
            if (Root.Value == value)
            {
                return null;
            }
            var parent = Root;
            while (true)
            {
                if(parent.Left.Value == value || parent.Right.Value == value)
                {
                    return parent;
                }
                var left = GetParent(parent.Left.Value);
                var right = GetParent(parent.Right.Value);
                if (right != null && left == null)
                {
                    return right;
                }
                else if(right == null && left != null)
                {
                    return left;
                }
                else
                {
                    return null;
                }
            }
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
