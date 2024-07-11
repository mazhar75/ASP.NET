// Problem Link:https://codeforces.com/problemset/problem/109/A
using System;
namespace nihad{
    class myclass{

        static void Solve(){
             int n;
             n = Convert.ToInt32(Console.ReadLine());
             int m=(n+3)/4;
             int a=0,b=0;
             for(int i=0;i<=m;i++){
               if(n-4*i>=0 && (n-4*i)%7==0){
                  a=i;
                  b=(n-4*i)/7;
                  break;
               }
             }
            // Console.WriteLine(a);
           //  Console.WriteLine(b);
             if(a==0 && b==0)  Console.WriteLine(-1);
             else{
             string ans="";
             for(int i=1;i<=a;i++)Console.Write("4");
             //Console.WriteLine(ans);
             for(int i=1;i<=b;i++)Console.Write("7");
             Console.WriteLine(ans);
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