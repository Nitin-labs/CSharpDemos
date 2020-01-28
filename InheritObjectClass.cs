using System;
namespace CSharp{
    class Google{
        public void headquarter(){
            Console.WriteLine("The Googleplex is the corporate headquarters complex of Google.");
        }        
    }
    class InheritObjectClass:Google{
        public void testObjectClass(){
            object obj=new object();
            Console.WriteLine("\n"+obj.GetType());
            Google g=new Google();
            Console.WriteLine(g.GetType());
            InheritObjectClass io=new InheritObjectClass();
            io.headquarter();
            Console.WriteLine(io.GetType());
        }
        }
}