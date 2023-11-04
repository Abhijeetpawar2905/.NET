/*4)Create class Student with private member variable prn_no,java,c#,Html,Total,Percentage
Write method public void get_total()
Write method public void get_Percentage()
Write method public string display()-> which will display prn_o , total, percentage
create two objects of class and display record
sol-*/

using System;
namespace Problem4
{
    public class Student
    {
        int prn_no;
        int java;
        int Csharp;
        int Html;
        double total;
        double percentage;

        public Student(int prn_no, int java, int Csharp, int Html)
        {
            this.prn_no = prn_no;
            this.java = java;
            this.Csharp = Csharp;
            this.Html = Html;
        }
        public void get_total()
        {
            total = java + Csharp + Html;
        }
        public void get_percentage()
        {
            percentage = (total / 300) * 100;
        }
        public string display()
        {
            get_total();
            get_percentage();
            return string.Format("PRN_No = {0} Total = {1} Percentage = {2}", prn_no, total, percentage);
        }
    }
    public class Demo
    {
        public static void Main()
        {
            Student student1 = new Student(001, 75, 87, 98);
            Student student2 = new Student(002, 90, 90, 90);
            Console.WriteLine("Info about Student1 is " + student1.display());
            Console.WriteLine("Info about  Student2 is " + student2.display());
        }
    }
}
