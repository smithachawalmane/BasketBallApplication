using System;
using System.Linq;

namespace BasketBallApplcation
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            int[] arr = { 26, 28, 31,40, 33, 36, 39 };
            int[] player = new int[arr.Length + 1];
            arr.CopyTo(player, 0);
            binaryTree.root= binaryTree.InsertLevelOrder(arr, binaryTree.root, 0);
            binaryTree.InOrder(binaryTree.root);
            Array.Sort(player);
            int[] sortedArray = player.Reverse().ToArray();
            bool found = false;

            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j == 0 && sortedArray[i] == arr[j])
                    {
                        break;
                    }
                    else if (j % 2 != 0 && sortedArray[i] == arr[j])
                    {
                        break;
                    }
                    else if (j % 2 == 0 && sortedArray[i] == arr[j])
                    {                       
                        Console.WriteLine("player with the ball " + arr[j]+" is the winner. " );

                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
