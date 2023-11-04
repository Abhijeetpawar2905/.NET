//2)Accept a Float value and print square of it
//solve above code using Parse,ToSingle,TryParse() and observe exception if you do not enter valid data 
using System;
namespace Problem2
{
	class Demo
	{
		public static float square(float num)
		{
			return num*num;
		}
		public static void Main()
		{
			float o;
			Console.WriteLine("Enter the number ");
			float value = float.Parse(Console.ReadLine());
			Console.WriteLine(square(value));

			Console.WriteLine("Enter the number ");
			float value1 = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine(square(value));

			Console.WriteLine("Enter the number ");
			bool b = float.TryParse(Console.ReadLine(),out o);
			if(b==true)
			{
				 Console.WriteLine(square(o));
			}
		}
	}
}
