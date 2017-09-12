using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] mas = { 10, 2, 3, 4, 5, 6, 2, 4, 1};
			for (int i = 0; i < mas.Length - 1; i++)
			{
				for (int j = i + 1; j < mas.Length; j++)
				{
					if (mas[i] > mas[j])
					{
						double temp = mas[j];
						mas[j]= mas[i];
						mas[i] = temp;
					}

				}
			}
			foreach (double a in mas)
			{
				Console.WriteLine(a);
					}

		}
	}
}
