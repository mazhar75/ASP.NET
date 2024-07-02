using System;
namespace University{
    class Program{
       
       public static void Main(string[] args){
          Student student=new Student("Mazhar","2019-20","2019331075","CSE");
          Console.WriteLine(student.GetIdentity());
       }

    }
}