3)Create class Account having member variable id,name, balance.
Write getter/setter for id, name and balance
create method deposit which will increase balance
Create two child class currentaccount and saving account
It has member type,
In both the class create withdraw method who’ s job is to reduce balance.
In currentaccount negative balance allowed
In savingaccount –ve balance not allowed.
When you load application it should print name of bank.
New Savingaccount(1,”Raj”,50000,” “saving”)
sol:
using System;
namespace Problem3
{
    public class Account
    {
        int id;
        static int getid;
        string name;
        protected double balance;
        static float InterestRate = 0.07f;
        const float minbal = 1000;
        double interest;

        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public double Interest
        {
            get { return interest; } 
            set { interest = value; } 
        }

        static Account()
        {
            Console.WriteLine("Bank of Spain @Infopro Limited.com");
        }

        public Account(string name, int balance = 0)
        {
            Name = name;
            Balance = balance;
            this.id = ++getid;
        }

        public void deposit(int amount)
        {
            if (amount > 0)
                balance += amount;
        }
	
	public void withdraw(int amount)
        {
                balance -= amount;
        }

        public static double payInt(Account obj)
        {
            obj.Interest = obj.balance * InterestRate;
            obj.balance += obj.Interest;
            return obj.Interest;
        }

        public void display()
        {
            Console.WriteLine("Name : {0} id : {1} balance : {2} interest  : {3}", name, id, balance, interest);
        }

    }
    public class CurrentAccount:Account
    {
	string style;
	public CurrentAccount(string name, int balance, string style="Current"):base(name, balance)
	{
		this.style = style;
	}
    }
    public class SavingAccount:Account
    {
	string style;
	public SavingAccount(string name, int balance, string style):base(name)
	{
		this.style = style;
		if (balance > 0)
                	Balance = balance;
            	else
            	{
                	throw new Exception("Balance should be greater than zero");
            	}
	}
	public void withdraw(int amount)
        {
            if (balance - amount > 1000)
            {
                base.withdraw(amount);
            }
            else
            {
                throw new Exception(" Not sufficient Balance ");
            }
        }
    }	

    public class Demo
    {
        public static void Main()
        {
            CurrentAccount acnt1=null;
            SavingAccount acnt2=null;
            try 
            {
                acnt1 = new CurrentAccount("KL", -10000);
            }
            catch(Exception ie)
            {
                Console.WriteLine(ie);
            }
            try
            {
                acnt2 = new SavingAccount("Raj",50000,"Saving");
            }
            catch (Exception ie)
            {
                Console.WriteLine(ie);
            }
            
            acnt1.deposit(50000);
            acnt2.deposit(600000);
            try { acnt1.withdraw(20000); }
            catch(Exception ie)
            {
                Console.WriteLine(ie);
            }
            try { acnt2.withdraw(40000); }
            catch(Exception ie)
            {
                Console.WriteLine(ie);
            }
            
            Console.WriteLine("Account1 has interest = "+Account.payInt(acnt1));
            Console.WriteLine("Account2 has interest = "+Account.payInt(acnt2));
            acnt1.display();
            acnt2.display();
        }

    }
}
