using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrderTree
{
    //middle, left, right
    public class PreOrderFactory
    {
        public static TreeNode ConvertArrayToPreOrderTree(int[] array)
        {
            return SetNode(array, 0, array.Length - 1);
        }

        public static TreeNode SetNode(int[] array, int start, int end)
        {
            if (start > end)
                return null;

            var mid = end + (start - end) / 2;

            var node = new TreeNode(array[start]);

            node.Left = SetNode(array, start + 1, mid);
            node.Right = SetNode(array, mid + 1, end);

            return node;
        }

        public static TreeNode GetBasicTree()
        {
            var root = new TreeNode(1)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(3),
                    Right = new TreeNode(4),
                },
                Right = new TreeNode(5)
                {
                    Left = new TreeNode(6)
                }
            };

            return root;
        }

        public static int[] GetPreOrderArray(TreeNode node)
        {
            var result = new List<int>();
            DFS(node, result);
            return result.ToArray();
        }

        private static void DFS(TreeNode node, List<int> list)
        {
            if (node == null)
                return;

            list.Add(node.Value);
            DFS(node.Left, list);
            DFS(node.Right, list);
        }
    }
}
