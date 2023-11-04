// 1) Create a Student class with member variables name, maths, science, eng.
// create a method which will return total marks [300]
// create a method which will display name and total.
// sol:
using System;
namespace Problem4
{
    public class Student
    {
        string name;
        int maths;
        int science;
        int eng;
        int marks;

        public Student(string name, int maths, int science, int eng)
        {
            this.name = name;
            this.maths = maths;
            this.science = science;
            this.eng = eng;
        }
        public void total_marks()
        {
            marks = maths + science + eng;
        }
        public string display()
        {
            total_marks();
            return string.Format("Name = {0} Total = {1} out of 300", name, marks);
        }
    }
    public class Demo
    {
        public static void Main()
        {
            Student student1 = new Student("Virat", 75, 87, 98);
            Student student2 = new Student("AB", 90, 90, 90);
            Console.WriteLine("Info about Student1 is " + student1.display());
            Console.WriteLine("Info about  Student2 is " + student2.display());
        }
    }
}
