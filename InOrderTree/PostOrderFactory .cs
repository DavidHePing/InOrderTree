using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrderTree
{
    //left, right, middle, 
    public class PostOrderFactory
    {
        public static TreeNode ConvertArrayToPostOrderTree(int[] array)
        {
            return SetNode(array, 0, array.Length - 1);
        }

        public static TreeNode SetNode(int[] array, int start, int end)
        {
            if (start > end)
                return null;

            var mid = end + (start - end) / 2;

            var node = new TreeNode(array[end]);

            node.Left = SetNode(array, start, mid - 1);
            node.Right = SetNode(array, mid, end - 1);

            return node;
        }

        public static TreeNode GetBasicTree()
        {
            var root = new TreeNode(6)
            {
                Left = new TreeNode(3)
                {
                    Left = new TreeNode(1),
                    Right = new TreeNode(2),
                },
                Right = new TreeNode(5)
                {
                    Left = new TreeNode(4)
                }
            };

            return root;
        }

        public static int[] GetPostOrderArray(TreeNode node)
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
            DFS(node.Right, list);
            list.Add(node.Value);
        }
    }
}
