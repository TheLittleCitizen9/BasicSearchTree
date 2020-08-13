
namespace BinarySearchTree
{
    public class BSTNode
    {
        public BSTNode(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public BSTNode Left { get; set; }

        public BSTNode Right { get; set; }

        public int Min()
        {
            if (Left == null)
            {
                return Value;
            }

            var minVal = Value;
            while (Left != null)
            {
                minVal = Left.Value;
            }

            return minVal;
        }

        public int Max()
        {
            if (Right == null)
            {
                return Value;
            }
            var maxVal = Value;
            while (Right != null)
            {
                maxVal = Right.Value;
            }

            return maxVal;
        }

        public bool AddItem(int value)
        {
            if(value > Value)
            {
                Right = new BSTNode(value);
                return true;
            }
            else
            {
                Left = new BSTNode(value);
                return true;
            }
        }

        public bool Contains(int value)
        {
            return FindItem(value) != null;
        }

        public BSTNode FindItem(int value)
        {
            if(Left != null && Right != null)
            {
                if (Left.Value == value)
                {
                    return Left;
                }
                else if (Right.Value == value)
                {
                    return Right;
                }
                else
                {
                    return null;
                }
            }
            else if(Right != null && Right.Value == value)
            {
                return Right;
            }
            else if (Left != null && Left.Value == value)
            {
                return Left;
            }
            else
            {
                return null;
            }
        }

        public bool DeleteItem(int value, BSTNode parent)
        {
            BSTNode nodeToDelete = parent.FindItem(value);
            if(nodeToDelete == null)
            {
                return false;
            }
            var left = nodeToDelete.Left;
            var right = nodeToDelete.Right;
            nodeToDelete.Left = null;
            nodeToDelete.Right = null;
            parent.Left = left;
            parent.Right = right;
            return true;
        }
    }
}
