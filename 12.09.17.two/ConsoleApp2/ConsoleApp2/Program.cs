using System;
using myInt = System.Int32;
namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			myInt i = 1; //присваиваем i=1
			myInt e = 1;
			i++; 
			Double b = 3.14;
			b--;
			Double q = i;
			Double w = 0;
			Console.WriteLine(b/i); //выводим на экран
			Console.WriteLine(q/w);

			e = (int)b;
			Console.WriteLine(b);
			Console.WriteLine(e);

			Color c = Color.White;
			c++;
			Console.WriteLine(c);
			Console.WriteLine((int)c);
			Mystruct s;
			s.Age = 55;

		}
			
	}
	struct Mystruct
		{
		public myInt Age;
	}
	enum Color
	{
		Red,
		Blue,
		Green,
		White=11,
		Black
				}
}
