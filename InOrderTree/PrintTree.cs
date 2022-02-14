using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrderTree
{
    public class PrintTree
    {
        public static void BfsPrint(TreeNode node)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var count = queue.Count;

                while (count > 0)
                {
                    count--;

                    var cur = queue.Dequeue();

                    if (cur == null)
                        continue;

                    Console.WriteLine(cur.Value);

                    queue.Enqueue(cur.Left);
                    queue.Enqueue(cur.Right);
                }
            }
        }
    }
}
