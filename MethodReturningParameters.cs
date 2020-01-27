using System;
namespace CSharp{
    class MethodReturningParameters{
        public static void displayName( string str1, string str2, string str3 ){
            string concatStr=str1+str2+str3;
            Console.WriteLine(concatStr);
        }
       public void combine(){
            displayName(str1:"\nMethod ",str2:" Returning ",str3:" Object");
        }
    }
}