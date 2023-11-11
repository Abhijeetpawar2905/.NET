/*1)   int[] a={5,8,9,2,1};
Q1. display all number<=5
Q2. display all even number
numbers.Where((r) => r %2==0).Select((data) => data);
from g in number where g%2==0  select g;
Q3. display all odd number
Q4 display all number>=8
String[] str={“hello”,”hi”,”go”,”bye”}
Q1. display all string starting with letter h
sol:*/

using System;
using System.Collections.Generic;
namespace Problem1
{
    class Demo
    {
        public static void Main()
        {
            int[] a = { 5, 8, 9, 2, 1 };
            var first = from i in a where i <= 5 select i;
            foreach (var i in first)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var second = from i in a where i % 2 == 0 select i;
            foreach (var i in second)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var third = from i in a where i % 2 != 0 select i;
            foreach (var i in third)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var fourth = a.Where((a) => a >= 8).Select((r) => r);
            foreach (var i in fourth)
            {
                Console.Write(i + " ");
            }

            String[] str = {"hello","hi","go","bye"};
            Console.WriteLine();
            var fifth = str.Where((N) => N.StartsWith('h')).Select((a) => a);
            foreach (var i in fifth)
            {
                Console.Write(i + " ");
            }
        }
    }
}
