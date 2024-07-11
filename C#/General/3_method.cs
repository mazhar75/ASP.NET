using System;
namespace nihad{
    class Method{
        static int Square(int n){
            return n*n;
        }
        public static void Main(string[] args){
            int n=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"Square of this number {n} is: {Square(n)}");
            

        }
    }
 }