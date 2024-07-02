//Disclaimer: The creator of 'C# Shell (C# Offline Compiler)' is in no way responsible for the content posted by any user.
using System;
using System.Linq;
using Association;

namespace Association{

public static class Program
{
	public static void Main()
	{
       Address address1=new Address();
	   Person person1 = new Person();
	   person1.FirstName="Mazharul";
	   person1.LastName="Islam";
	   address1.HouseNo="12";
	   address1.Area="Shibgonj";
	   address1.RoadNo="09";
	   address1.State="Sylhet";
	   person1.address=address1;
	   Console.WriteLine(person1.FullName());
	   Console.WriteLine(person1.FullAddress());
	}
}
}