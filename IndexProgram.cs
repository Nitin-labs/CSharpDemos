using System;

namespace CSharp
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CharToInt c=new CharToInt();
            c.test();
            Arithmatic a=new Arithmatic();
            a.arithmaticOp();
            ArrayDemo ar=new ArrayDemo();
            ar.test();
            TwoDArray td=new TwoDArray();
            td.testTwoD();
            JaggadArray j=new JaggadArray();
            j.testJagArr();
            ArrayResizing ars=new ArrayResizing();
            ars.testArrResize();
            ArrayCopyToMethod ct=new ArrayCopyToMethod();
            ct.copyToMethod();
            StaticDemo sd=new StaticDemo();
            sd.testStatic();
            NullCoalescingOperator nc=new NullCoalescingOperator();
            nc.testOperator();
            GetValueOrDefaultDemo gvd=new GetValueOrDefaultDemo();
            gvd.testGetValueOrDefault();
            NullableHasValueDemo nhv=new NullableHasValueDemo();
            nhv.testNullableHasValue();
            VariableScope vs=new VariableScope();
            vs.testVariableScope();

            // ReadNumCLI r=new ReadNumCLI();
            // r.test()

        }
    }
}
