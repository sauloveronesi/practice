using System.Collections.Generic;

namespace Practice2017
{
    public class BST
    {
        public static bool IsBST(BinaryTreeNode root)
        {
            return IsBST(root, int.MinValue, int.MaxValue);
        }

        private static bool IsBST(BinaryTreeNode node, int min, int max)
        {
            if (node == null)
                return true;

            if (node.Value < min || node.Value > max)
                return false;

            return IsBST(node.Left, min, node.Value) && IsBST(node.Right, node.Value, max);
        }

        public static int SecondLargest(BinaryTreeNode root)
        {
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();

            stack.Push(root);

            int count = 0;

            while (stack.Count > 0 && count < 1)
            {
                var node = stack.Pop();

                if (node == null)
                {
                    count++;
                    continue;
                }

                stack.Push(node.Left);
                stack.Push(node.Right);
            }

            return stack.Pop().Value;
        }
    }
}
