//Disclaimer: The creator of 'C# Shell (C# Offline Compiler)' is in no way responsible for the content posted by any user.
using System;
using System.Linq;

namespace BankProject{

public static class Program
{
	public static void Main()
	{
         SavingAccount r=new SavingAccount();
		 r.Id="RA-001";
		 r.Name="Md. Islam";
		 SpecialAccount s= new SpecialAccount();
		 s.Id="SA-101";
		 s.Name="Mazhar";
		 Console.WriteLine(r.Deposit(5000));
		 Console.WriteLine(r.Withdraw(6000));
		 Console.WriteLine(s.Deposit(5000));
		 Console.WriteLine(s.Withdraw(6000));
		 
	}
}
}