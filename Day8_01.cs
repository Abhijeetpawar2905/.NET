/*1) Task: Create two static methd
a.  Public static int add(int a,int b) ==return sum of two number
b.  Public static int product(int a,int b)==return a*b;
Declare delegate which can point to this method.
Using reference of delegate call this method and print result
Solve above program by making above method as instance method.
sol:*/

using System;
namespace Problem1
{
	delegate int calcDelg(int x, int y);
	class Calc
	{
		public static int add(int a, int b)
		{
			return a+b;
		}
		public static int product(int a, int b)
		{
			return a*b;
		}
	}
	class CalDemo
	{
		public static void Main()
		{
			calcDelg calc1 = new calcDelg(Calc.add);
			calc1(10,20);
			calcDelg calc2 = Calc.product;
			calc2(10,20);
		}
	}
}

using System;
namespace Problem1
{
	delegate int calcDelg(int x, int y);
	class Calc
	{
		public int add(int a, int b)
		{
			return a+b;
		}
		public int product(int a, int b)
		{
			return a*b;
		}
	}
	class CalDemo
	{
		public static void Main()
		{
			calcDelg calc1 = new calcDelg(new Calc().add);
			calc1(10,20);
			calcDelg calc2 = new Calc().product;
			calc2(10,20);
		}
	}
}

