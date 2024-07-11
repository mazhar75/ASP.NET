//Disclaimer: The creator of 'C# Shell (C# Offline Compiler)' is in no way responsible for the content posted by any user.
using System;
using System.Linq;
using System.Collections.Generic;
using Association;

namespace Association{

public class Person 
{         
  public string FirstName{get;set;}
  public string LastName{get;set;}
  public Address address{get;set;}
  
  public string FullName(){
	  return FirstName+" "+LastName;
  }
  public string FullAddress(){
	  return address.HouseNo+" "+address.Area+" "+address.RoadNo+" "+address.State;
  }  
}
}
