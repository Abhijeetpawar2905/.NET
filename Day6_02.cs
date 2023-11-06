/*2) Write a method which will accept two number and return all even number between it as array and also give count in out variable.
int count;
int[] result = Dojob(5,30);
sol:*/
using System;
namespace Problem2
{
    public class Demo
    {
        public static int[] Dojob(int start, int end, out int count)
        {
            int[] even = new int[((end - start)+1)/2];
            count = 0;
            while (start <= end)
            {
                if (start % 2 == 0)
                {
                    even[count++] = start;
                    start += 2;
                }
                else
                {
                    even[count++] = start + 1;
                    start += 2;
                }
            }
            return even;
            
        }
        public static void Main()
         {
                int count;
                int[] result = Dojob(5, 30, out count);
                foreach(int i in result) { Console.WriteLine(i); }    
        }
    }
}
