/*Q2.create a class account having member name , id, balance
Create a method -public void deposit(int amt) { balance = balance + amt}
Create a method withdraw  -public void withdraw(int amt) { balance = balance - amt}
Create display method which will display name and balance.
Create 2 object and do transaction. */


using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DAY7_Assignment
{
    class account
    {
        String name;
        int id;
        int balance;

        public account(string name, int id, int balance) 
        {
            this.name = name;
            this.id = id;   
            this.balance = balance;
        }
    
        public void deposit(int amt)
        {
            balance = balance + amt;

        }
        public void withdraw(int amt)
        {
            balance = balance - amt;
        }

        public void display()
        {
            Console.WriteLine("name : {0} \n And current blance after transaction is : {1}", name, balance);
        }
    }
    class Demo
    {
        public static void Main()
        {
            account a1 = new account(" Abhi", 2, 70000);
            a1.deposit(10000);
            a1.withdraw(50000);
            a1.display();
        }
    }
}