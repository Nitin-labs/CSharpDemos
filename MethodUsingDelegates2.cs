using System;
namespace CSharp{
    class MethodUsingDelegates2{
        public void testDelegates(){
            MethodUsingDelegates1 mext=new MethodUsingDelegates1();
            sumdelegate sumdeleg=new sumdelegate(mext.sum);
            greetdelegate greetdeleg=new greetdelegate(MethodUsingDelegates1.greet);
            Console.WriteLine("\nUsing delegate Reference ");
            sumdeleg(27,65);
            Console.WriteLine("\nUsing delegate Invoke Method "+greetdeleg.Invoke("Vijayan"));
                    
        }
    }
}