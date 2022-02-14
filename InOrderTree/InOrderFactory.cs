using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrderTree
{
    //left, middle, right
    public class InOrderFactory
    {
        public static TreeNode ConvertArrayToInOrderTree(int[] array)
        {
            return SetNode(array, 0, array.Length - 1);
        }

        public static TreeNode SetNode(int[] array, int start, int end)
        {
            if (start > end)
                return null;

            var mid = end + (start - end) / 2;

            var node = new TreeNode(array[mid]);

            node.Left = SetNode(array, start, mid - 1);
            node.Right = SetNode(array, mid + 1, end);

            return node;
        }

        public static TreeNode GetBasicTree()
        {
            var root = new TreeNode(4)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(1),
                    Right = new TreeNode(3),
                },
                Right = new TreeNode(6)
                {
                    Left = new TreeNode(5)
                }
            };

            return root;
        }

        public static int[] GetInOrderArray(TreeNode node)
        {
            var result = new List<int>();
            DFS(node, result);
            return result.ToArray();
        }

        private static void DFS(TreeNode node, List<int> list)
        {
            if (node == null)
                return;

            DFS(node.Left, list);
            list.Add(node.Value);
            DFS(node.Right, list);
        }
    }
}
