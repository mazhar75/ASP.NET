// Problem Link:https://codeforces.com/problemset/problem/318/A
using System;
namespace nihad{
    class myclass{

        static void Solve(){
             long n,m;
             string input = Console.ReadLine();
             string[] parts = input.Split(' ');
             n = Convert.ToInt64(parts[0]);
             m = Convert.ToInt64(parts[1]);
             if(m<=(n+1)/2){
                Console.WriteLine(2*m-1);
             }
             else{
                m-=(n+1)/2;
                 Console.WriteLine(2*m);

             }
             
        }
        public static void Main(string[] args){
            int t=1,testcases=1;
            //testcases=Convert.ToInt32(Console.ReadLine())
            while(t<=testcases){
                Solve();
                t++;
            }

        }
    }
}