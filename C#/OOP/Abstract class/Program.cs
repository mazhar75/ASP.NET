using System;
using System.Collections.Generic;

namespace University
{
    public class Program
    {
        public static void Main(string[] args)
        {  

            // Object initializer
            
            Student student = new Student()
            {
                Name = "Md. Mazharul Islam",
                Reg = "2019331075"
            };

            Teacher teacher = new Teacher()
            {
                Name = "Mr. X",
                ID  = "001"
            };
            
            // Association 

            List<Identity> IdentityInfo = new List<Identity>();
            IdentityInfo.Add(student);
            IdentityInfo.Add(teacher);

            foreach (Identity identity in IdentityInfo)
            {
                Console.WriteLine(identity.CallTo());
                Console.WriteLine(identity.CallFrom());

                // Runtime Polymorphism 

                Console.WriteLine(identity.GetInfo());
                Console.WriteLine("------------------");
            }
        }
    }
}
