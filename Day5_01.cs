//1) Create 2 string variable and accept data from user. Using equals and == check data entered by user is same or not.print gethashcode for both string varible. Also use referenceEquals and observe output.
//sol:
using System;
namespace Problem1
{
	class Demo
	{
		public static void Main()
		{
			string str1 = Console.ReadLine();
			string str2 = Console.ReadLine();
		
			Console.WriteLine("str1.Equals(str2) : "+str1.Equals(str2));
			Console.WriteLine(str1 == str2);
			Console.WriteLine("Hashcode for str1 : "+str1.GetHashCode());
			Console.WriteLine("Hashcode for str2 : "+str2.GetHashCode());
			Console.WriteLine("Object.Equals(str1,str2) : "+Object.Equals(str1,str2));
			Console.WriteLine("Object.ReferenceEquals(str1,str2) : "+Object.ReferenceEquals(str1,str2));
		}
	}
}
