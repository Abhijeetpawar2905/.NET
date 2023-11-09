/*1)Create class Account having member id, name , balance.
Id autoincrement write read only property
Write getter setter for name and balance.
Balance can be modified only by child class.
This has virtual withdraw method which will 0.
It has deposit method.
Create two child class current and saving and override withdraw method. 
Create reference of Account class and point to saving account
and  current account. Using parent’s reference call withdraw method and deposit method.
Use ToString method to display status of the object [id name balance]
sol:*/
using System;
namespace Problem1
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
            protected set { balance = value; }
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

        public virtual void withdraw(int amount)
        {
            Balance += 0;
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
    public class CurrentAccount : Account
    {
        string style;
        public CurrentAccount(string name, int balance, string style = "Current") : base(name, balance)
        {
            this.style = style;
        }

        public override void withdraw(int amount)
        {
            balance -= amount;
        }
    }
    public class SavingAccount : Account
    {
        string style;
        public SavingAccount(string name, int balance, string style) : base(name)
        {
            this.style = style;
            if (balance > 0)
                Balance = balance;
            else
            {
                throw new Exception("Balance should be greater than zero");
            }
        }
        public override void withdraw(int amount)
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
            Account acnt1 = null;
            Account acnt2 = null;
            try
            {
                acnt1 = new CurrentAccount("KL", -10000);
            }
            catch (Exception ie)
            {
                Console.WriteLine(ie.Message);
            }
            try
            {
                acnt2 = new SavingAccount("Raj", 50000, "Saving");
            }
            catch (Exception ie)
            {
                Console.WriteLine(ie.Message);
            }

            acnt1.deposit(50000);
            acnt2.deposit(600000);
            try { acnt1.withdraw(20000); }
            catch (Exception ie)
            {
                Console.WriteLine(ie.Message);
            }
            try { acnt2.withdraw(40000); }
            catch (Exception ie)
            {
                Console.WriteLine(ie.Message);
            }

            Console.WriteLine("Account1 has interest = " + Account.payInt(acnt1));
            Console.WriteLine("Account2 has interest = " + Account.payInt(acnt2));
            acnt1.display();
            acnt2.display();
        }

    }
}
