using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			Node tree = new Node();
			tree.SetData(5);
			tree.SetLeft(new Node());
			tree.SetRight(new Node());
		}
	}
	class Node
	{
		int data;
		Node left;
		Node right;
		public Node GetRight() { return right; }
		public Node GetLeft() { return left; }
		public int GetData() { return data; }
		public void SetRight(Node n) { right = n; }
		public void SetLeft(Node n) { left = n; }
		public void SetData(int d) { data = d; }
	}
}
