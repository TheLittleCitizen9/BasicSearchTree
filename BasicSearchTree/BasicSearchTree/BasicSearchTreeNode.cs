
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
            throw new System.NotImplementedException();
        }

        public bool Contains(int value)
        {
            return FindItem(value) != null;
        }

        public BSTNode FindItem(int value)
        {
            if(Value == value)
            {
                return this;
            }
            if(Left == null && Right == null)
            {
                return null;
            }
            var lRes = FindItem(Left.Value);
            var rRes = FindItem(Right.Value);
            if(lRes != null)
            {
                return lRes;
            }
            else
            {
                return rRes;
            }
        }

        public bool DeleteItem(int value, BSTNode parent)
        {
            throw new System.NotImplementedException();
        }
    }
}
