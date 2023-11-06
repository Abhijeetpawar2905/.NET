3)Create array of class Account and display name and balance 
sol:
using System;
namespace Problem3
{
	class Account
	{
		string name;
		double balance
	
		public Account(string name, double balance)
		{
			Name = name;
			Balance	= balance;
		}
		public string Name
		{
			get{return name;}
			set{name = value;}
		}
		public double Balance
		{
			get{return balance;}
			set{balance = value;}
		}
		public static void main()
		{
			Account[] account = new Account[3];
			account[0] = new Account("AB",5000);
			account[1] = new Account("Starc",6000);
			account[2] = new Account("joe",7000);
			foreach(int i in account)
			{
				Console.WriteLine("Name : "+i.Name+" Balance : "+i.Balance);
			}
		}	
	}
}











