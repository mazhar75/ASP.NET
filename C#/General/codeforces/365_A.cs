// Problem Link:https://codeforces.com/problemset/problem/365/A
using System;
namespace nihad{
    class myclass{

        static void Solve(){
             int n,k;
             string input = Console.ReadLine();
             string[] parts = input.Split(' ');
             n = Convert.ToInt32(parts[0]);
             k = Convert.ToInt32(parts[1]);
             int x=0;
             int cnt=0;
             int [] a=new int [k+1];
             while(n>0){
               x=Convert.ToInt32(Console.ReadLine());
               for(int i=0;i<=k;i++)a[i]=0;
               bool f=true;
               while(x>0){
                 if(x%10>k){
                    f=false;
                    break;
                 }
                 else{
                    a[x%10]++;
                 }
                 x=x/10;
               }
               if(f){
                 for(int i=0;i<=k;i++){
                    if(a[i]==0){
                       f=false;
                       break;
                    }
                 }
                 if(f)cnt++;
               }

               n--;
             }
             Console.WriteLine(cnt);
             
             
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