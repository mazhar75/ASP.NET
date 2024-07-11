using System;

namespace University
{
    abstract class Identity{

        public string Name{get;set;}
        
        public virtual string CallFrom(){
       
         return "Identity class";
         
        }
        public string CallTo(){
              return "I am inside abstract class";
        }
        public abstract string GetInfo();
    }
}