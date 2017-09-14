using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass myclass = new MyClass();
			myclass.data = 10;
			IncreasseData(myclass);
			Console.WriteLine(myclass.data);
		}
		static void IncreasseData(MyClass c)
		{
			c.data++;
		}
	}
	class MyClass
	{
		public int data;
	}
}
