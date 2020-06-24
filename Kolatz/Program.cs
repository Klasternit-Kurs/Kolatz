using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolatz
{
	class Program
	{
		static void Main(string[] args)
		{
			int broj;
			while (true)
			{
				Console.Write("Unesite broj: ");
				broj = int.Parse(Console.ReadLine());
				if (broj <= 1)
				{
					Console.WriteLine("Broj mora biti veci od 1");
				//	continue;
				}
				else
				{
					break;
				}
			}
			Console.WriteLine($"Izabrali ste {broj}");
			while(broj != 1)
			{
				if (broj%2 == 0)
				{
					broj /= 2;
				} else
				{
					broj = broj * 3 + 1;
				}
				Console.WriteLine(broj);
			}
			Console.ReadKey();
		}
	}
}
