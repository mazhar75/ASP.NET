// Problem Link:https://codeforces.com/problemset/problem/80/A
using System;
namespace nihad{
    class myclass{

        static void Solve(){
             int n,m;
             string input = Console.ReadLine();
             string[] parts = input.Split(' ');
             n = Convert.ToInt32(parts[0]);
             m = Convert.ToInt32(parts[1]);
             bool f=true;
            for(int i=n+1;i<m;i++){
                 int j=2;
                 bool found=false;
                 while(j<i){
                    if(i%j==0){
                      found = true;
                      break;
                    }
                    j++;
                 }
                 if(!found){
                    f=false;
                    break;
                 }
            }
            if(f){
                for(int i=2;i<m;i++){
                    if(m%i==0){
                        f=false;
                        break;
                    }
                }
                if(f)Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
            else Console.WriteLine("NO");
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