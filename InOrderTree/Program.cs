using System;
using System.Text.Json;

namespace InOrderTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //var array = new int[] { 1, 2, 3, 4, 5, 6, 7,8,9,10,11,12,13,14};
            //var node = InOrderFactory.ConvertArrayToInOrderTree(array);
            //PrintTree.BfsPrint(node);

            //var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //var node = PreOrderFactory.ConvertArrayToPreOrderTree(array);
            //PrintTree.BfsPrint(node);

            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var node = PostOrderFactory.ConvertArrayToPostOrderTree(array);
            PrintTree.BfsPrint(node);

        }
    }
}
