/*1) Write a method which will return sum of digit and using out variable let it send count of digit also. i/p input 123 return 6 in out  varible (3) 
sol:*/
using System;
namespace Problem1
{
    public class Demo
    {
        public static int sum_of_digits(int num, out int var)
        {
            var = 0;
            int sum = 0;
            while (num > 0)
            {
                var++;
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        public static void Main()
        {
            int number = 123;
            int count;
            Console.WriteLine("sum of digits : "+sum_of_digits(number, out count));
            Console.WriteLine("count of digits : "+count);
        }
    }
}
