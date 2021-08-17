using System;
using System.Collections.Generic;
using System.Text;

namespace BasketBallApplcation
{
   public class BinaryTree
    {
		public Node root;
		
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

		
		public Node InsertLevelOrder(int[] arr,
								Node root, int i)
		{			
			if (i < arr.Length)
			{
				Node temp = new Node(arr[i]);
				root = temp;
				
				root.left = InsertLevelOrder(arr,
								root.left, 2 * i + 1);
				
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
