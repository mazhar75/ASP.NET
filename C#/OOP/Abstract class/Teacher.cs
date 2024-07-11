using System;

namespace University
{
    //Inheritance
    class Teacher:Identity{
     
       public string ID{get;set;}
       
       //Method Overriding

       public override string CallFrom(){

           return "I am inside teacher class";

       }
       public override string GetInfo(){

        return $"Name : {Name} Reg:{ID}";
        
       }

    }
}