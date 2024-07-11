using System;

namespace University{
   
   class Student:IIdentity{
   public string Name{get;set;}

   public string Session{get;set;}

   public string Reg{get;set;}

   public string Department{get;set;}
   
  public Student(){

   }
   public Student(string Name,string Session,string Reg,string Department):this(){
      this.Name=Name;
      this.Session=Session;
      this.Reg=Reg;
      this.Department=Department;
   }
   public string GetIdentity(){
     return $"Name:{Name} Session:{Session} Reg:{Reg} Department:{Department}";
   }
    

   }

}