//Use of "null-coalescing operator(??)" used to define a default value for nullable value types or reference types. 
//It returns the left-hand operand if the operand is not null; otherwise, it returns the right operand.
using System;
namespace CSharp{

class NullCoalescingOperator{
public void testOperator(){
    int ? a=null;
    int ? c=5;
    int b=a??3;
    int d=c??8;
    Console.WriteLine(b+"\n"+d);
}
}
}