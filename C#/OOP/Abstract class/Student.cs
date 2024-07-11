using System;

namespace University
{
    class Student:Identity{
     
       public string Reg{get;set;}
       
       //Method overriding 

       public override string CallFrom(){

           return "I am inside student class";

       }
       //Abstract Method
       
       public override string GetInfo(){

        return $"Name : {Name} Reg:{Reg}";

       }

    }
}