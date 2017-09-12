using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			double a = 1;
			double b = 5;
			double x;
			string res = Console.ReadLine();
			if (double.TryParse(res, out x))// if, else
			{
				if ((x >= a) && (x <= b))
				{
					Console.WriteLine("x больше или равоно 1 и меньше или равно 5");
				}
				else
				{
					Console.WriteLine("x меньше 1 или больше 5");
				}
			}
			else
			{
				Console.WriteLine("Error");
			}
			Console.WriteLine("\n");

			int i = 0;                      //while
			while (i <= 5)
			{
				Console.WriteLine(i++);
			}

			Console.WriteLine("\n");
			int l = 0;                     //while do
			do
			{
				Console.WriteLine(l++);
			}
			while (l <= 5);
			Console.WriteLine("\n");

			for (int r = 0; r <= 5; r++)     //for
			{
				Console.WriteLine(r);
			}
		}
	}
}
