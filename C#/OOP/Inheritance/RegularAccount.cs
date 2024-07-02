//Disclaimer: The creator of 'C# Shell (C# Offline Compiler)' is in no way responsible for the content posted by any user.
using System;
using System.Linq;
using System.Collections.Generic;

namespace BankProject{

public class RegularAccount 
{         
        public string Id{get;set;}
		public string Name{get;set;}
		public double Balance{get;private set;}
		
		public string Deposit(double amount){
			Balance+=amount;
			return "Deposited";
		}
		public virtual string Withdraw(double amount){
			Balance-=amount;
			return "Withdrawn";
		}
}
}
