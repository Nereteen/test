using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Math.Add(x: 77, z:11));
		}

		class Math
		{
			public static double Add(double x, double y=33, double z = 33)
			{
				return x + y+z;
			}
		}


	}
}
