// 1) Same Account Problem using Anonymous methods
// using System;
namespace Problem1
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

    class Demo
    {
        public static void Main()
        {
            Employee[] employee = new Employee[2];
            employee[0] = new permenantEmp("Virat", 70000);
            employee[1] = new tempEmp("Siraj", 20000);

            for(int i=0; i<employee.Length; i++)
            {
                employee[i].eventref += delegate
		{
			Console.WriteLine(" SMS : Salary is deposited in your account ");
		};
                employee[i].eventref += delegate
		{
			Console.WriteLine(" Email : Salary is deposited in your account ");
		};
            }
            employee[0].givebonus();
            employee[1].givebonus();
            employee[0].givebasic_salary();
            employee[1].givebasic_salary();
        }
    }
}

