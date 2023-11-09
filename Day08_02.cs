// 2)Create delegate Delegate void math(int a, int b)  Write static method Add to add 2 number  and print it.and product which will display product of 2 number
// Create a variable which can point to add and then to product and wirh single method call invoke both the method.
// sol:
using System;
namespace Problem2
{
	delegate void math(int a, int b);
	class Calc
	{
		public static void add(int x, int y)
		{
			Console.WriteLine(x+y);
		}
		public static void product(int x, int y)
		{
			Console.WriteLine(x*y);
		}
	}
	class CalDemo
	{
		public static void Main()
		{
			math m1 = new math(Calc.add);
			math m2 = Calc.product;
			math m = m1;
			m += m2;
			m.Invoke(10,20);
		}
	}
}
