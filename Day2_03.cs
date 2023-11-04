/*3) create a class calculator and create 3 instance method square, cube, round[input 22.5 then o/p 22]
which will return square cube and rounded number.create object and call method and print the result*/
using System;
namespace Problem3
{
    class Calculator
    {
        public int square(int num)
        {
            return num * num;
        }
        public int cube(int num)
        {
            return num * num * num;
        }
        public int round(float num)
        {
            return (int) num;
        }
    }

    class Demo
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.square(int.Parse(Console.ReadLine())));
            Console.WriteLine(calculator.round(float.Parse(Console.ReadLine())));
            Console.WriteLine(calculator.cube(int.Parse(Console.ReadLine())));

            Console.WriteLine(calculator.square(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine(calculator.round(Convert.ToSingle(Console.ReadLine())));
            Console.WriteLine(calculator.cube(Convert.ToInt32(Console.ReadLine())));

            int a;
            float b;
            int c;
            if (int.TryParse(Console.ReadLine(), out a) == true)
                Console.WriteLine(calculator.square(a));
            if (float.TryParse(Console.ReadLine(), out b) == true)
                Console.WriteLine(calculator.round(b));
            if (int.TryParse(Console.ReadLine(), out c) == true)
                Console.WriteLine(calculator.cube(c));
        }
    }

}
