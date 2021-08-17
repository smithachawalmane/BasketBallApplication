using System;
using System.Collections.Generic;
using System.Text;

namespace BasketBallApplcation
{
   public class BinaryTree
    {
		public Node root;

		// Tree Node
		public class Node
		{
			public int data;
			public Node left, right;
			public Node(int data)
			{
				this.data = data;
				this.left = null;
				this.right = null;
			}
		}

		// Function to insert nodes in level order
		public Node InsertLevelOrder(int[] arr,
								Node root, int i)
		{
			// Base case for recursion
			if (i < arr.Length)
			{
				Node temp = new Node(arr[i]);
				root = temp;

				// insert left child
				root.left = InsertLevelOrder(arr,
								root.left, 2 * i + 1);

				// insert right child
				root.right = InsertLevelOrder(arr,
								root.right, 2 * i + 2);
			}
			return root;
		}

		public object SearchElement_Rec(object element, Node root)
		{

			Node current = root;

			if (current == null)

				return "Not found";

			if (Convert.ToInt32(element) == Convert.ToInt32(current.data))
			{
				return current;
			}

			if (Convert.ToInt32(element) < Convert.ToInt32(current.data))

				return this.SearchElement_Rec(element, current.left);

			else

				return this.SearchElement_Rec(element, current.right);

		}

		// Function to print tree
		// nodes in InOrder fashion
		public void InOrder(Node root)
		{
			if (root != null)
			{
				InOrder(root.left);
				Console.WriteLine(root.data + " ");
				InOrder(root.right);
			}
		}
	}
}
