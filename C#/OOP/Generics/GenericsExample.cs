using System;
using System.Collections.Generic;

namespace GenericsExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student<int> student1 = new Student<int>()
            {
                Name = "Mazhar",
                Result = 1
            };
            Student<string> student2 = new Student<string>()
            {
                Name = "Arham",
                Result = "Pass"
            };
            Student<bool> student3 = new Student<bool>()
            {
                Name = "Rigan",
                Result = false
            };

            Print(student1);
            Print(student2);
            Print(student3);

        }
        public static void Print<T>(Student<T> student)
        {
            Console.WriteLine(student.Name + " " + student.Result);

        }
    }

    public class Student<T>
    {
        public string Name { get; set; }
        public T Result { get; set; }
    }
}
