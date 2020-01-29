using System;
namespace CSharp{
    interface IAdd
    {
        void add(int a,int b);
    }
interface IMul:IAdd
{
    void mul(int a, int b);
}    
class InterfaceDemo:IMul{
    public void add(int a,int b){
        Console.WriteLine("Addition :"+(a+b));
    }
    public void mul(int a, int b){
        Console.WriteLine("Multiplication :"+a*b);
    }
    public void testInterface(){
        Console.WriteLine("\n---**Interface Demo**---");
        InterfaceDemo i=new InterfaceDemo();
        i.add(6,8);
        i.mul(4,7);
    }
}
}