// 3)Create abstract class Employee having member id, name, salary, netsalary.  It has method givebasic_salary which will set netsalary after deduction 10%TDS
// it has abstract method givebonus ,Id should be autoincrement and should be readonly property  Write getter setter for name and salary. Salary can be set only by child class Create two child class permanentEmp and tempEmp  permanentEmp get bonus of 10%[ declare this as static variable ] const maxsalay=150000. Ensure that you are not paying more then 150000 to any employee. Bonus for tempEmp is 5% of the basic salary. When you load application it should print name of company. When you give salary it should give SMS and Email to the employee. Create Array of Employee and store all child class object.
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
    class Demo
    {
        public static void Main()
        {
            Employee[] employee = new Employee[2];
            employee[0] = new permenantEmp("Virat", 70000);
            employee[1] = new tempEmp("Siraj", 20000);

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
