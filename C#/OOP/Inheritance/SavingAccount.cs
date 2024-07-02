//Disclaimer: The creator of 'C# Shell (C# Offline Compiler)' is in no way responsible for the content posted by any user.
using System;
using System.Linq;
using System.Collections.Generic;
using BankProject;

namespace BankProject{

public class SavingAccount : RegularAccount
{         
      public double Interest{get;set;}
	  public override string Withdraw(double amount){
		  if(amount<=Balance){
			  return base.Withdraw(amount);
		  }
		  else return "Insufficient Balance";
	  }
}
}
