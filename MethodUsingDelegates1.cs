using System;
namespace CSharp{
    public delegate void sumdelegate(int i,int j);
    public delegate string greetdelegate(string str);
class MethodUsingDelegates1{
    public void sum(int x, int y){
        Console.WriteLine(x+y);
    }
    public static string greet(string name){
        return "\nNamaste "+name;
    }
}
}