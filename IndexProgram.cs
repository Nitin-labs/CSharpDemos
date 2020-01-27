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
            Arithmatic arth=new Arithmatic();
            arth.arithmaticOp();
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
            DataTypeTest dt=new DataTypeTest();
            dt.testDataType();
            AccessModifierPublic pub=new AccessModifierPublic();
            pub.testPublic();
            AccessModifiersProtected prot=new AccessModifiersProtected();
            prot.testProtected();
            AccessModifiersInternal intern=new AccessModifiersInternal();
            intern.testInternal();
            MethodLongestString ml=new MethodLongestString();
            ml.testFindLongest();
            MethodRecursiveFact mr=new MethodRecursiveFact();
            mr.testFactorial();
            MethodReturngObject mro=new MethodReturngObject();
            mro.testSDCard();
            MethodReturningParameters mrp=new MethodReturningParameters();
            mrp.combine();
            MethodPartial mpr=new MethodPartial();
            // mpr.OnSomethingHappened("Nitin");
            MethodExtension1 me=new MethodExtension1();
            me.test4();me.test5("Extended Method");
            string s="I AM STILL WORTHY";
            Console.WriteLine("\n"+s+" ==> "+s.toProper());
            MethodUsingDelegates2 mud2=new MethodUsingDelegates2();
            mud2.testDelegates();
            MethodDelegateMulticast mdm = new MethodDelegateMulticast();
            mdm.testMulticast(45);

            MethodAnnonymous ma=new MethodAnnonymous();
            ma.testAnnonymous("Koduko");
            KeywordGetSet kgs=new KeywordGetSet();
            kgs.testGetSet();

            KeywordAs ka=new KeywordAs();
            ka.testAsKeyword();

            KeywordIs ki=new KeywordIs();
            ki.testIsKeyword();

            IfDemo if1=new IfDemo();
            if1.testEvenOdd();
            if1.testGreater();
            SwitchDemo swd=new SwitchDemo();
            swd.testSwitch();





            // ReadNumCLI r=new ReadNumCLI();
            // r.test()

        }
    }
}
