// 4) above problem using user defined exception;
// sol:
using System;
namespace Problem3
{
    delegate void Eventwatch();
    abstract class Employee
    {
        int id;
        static int getid;
        string name;
        double salary;
        double netSalary;
        const double TDS = 0.10;
        const double maxsalary = 150000;
        public event Eventwatch eventref;
        public void onSalary()
        {
            if (eventref != null)
            {
                eventref();
            }
        }
        static Employee()
        {
            Console.WriteLine(" Person Specter Litt ");
        }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 150000)
                {
                    salary = value;
                }
                else
                {
                    throw new MyException(Salary, Name, "Please enter salary less than 150000");
                }
            }
        }
        public double NetSalary
        {
            get { return netSalary; }
            set { netSalary = value; }
        }
        public double givebasic_salary()
        {
            NetSalary = Salary - Salary * TDS;
            onSalary();
            return NetSalary;
        }
        public abstract void givebonus();
    }

    class permenantEmp : Employee
    {
        public permenantEmp(string name, double salary) : base(name, salary)
        {
        }

        public override void givebonus()
        {
            NetSalary += NetSalary * 0.10;
        }
    }

    class tempEmp : Employee
    {
        public tempEmp(string name, double salary) : base(name, salary)
        {
        }

        public override void givebonus()
        {
            NetSalary += NetSalary * 0.05;
        }
    }

    class Publisher
    {
        public static void sms()
        {
            Console.WriteLine(" SMS : Salary is deposited in your account ");
        }
        public static void email()
        {
            Console.WriteLine(" Email : Salary is deposited in your account ");
        }
    }
    public class MyException : ApplicationException
    {
        readonly double salary;
        readonly string name;
        public string msg;
        public MyException(double salary, string name, string msg)
        {
            this.salary = salary;
            this.name = name;
            this.msg = msg;
        }
    }
    class Demo
    {
        public static void Main()
        {
            Employee[] employee = new Employee[2];
            try
            {
                employee[0] = new permenantEmp("Virat", 70000);
                employee[1] = new tempEmp("Siraj", 20000);
                tempEmp tempe = new tempEmp("Noname", 50000000);
                Console.WriteLine("This will not be printed");
            }
            catch(MyException ie)
            {
                Console.WriteLine(ie.msg);
            }

            for(int i=0; i<employee.Length; i++)
            {
                employee[i].eventref += Publisher.sms;
                employee[i].eventref += Publisher.email;
            }
            employee[0].givebonus();
            employee[1].givebonus();
            employee[0].givebasic_salary();
            employee[1].givebasic_salary();
        }
    }
}
