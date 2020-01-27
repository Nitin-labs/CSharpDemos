using System;
namespace CSharp
{
    class IfDemo
    {
        public void testEvenOdd()
        {

           // Console.WriteLine("\nUsing if..else.. statement\nEnter no. to check for ");
            int num = 53;//Console.Read();
            if (num / 2 == 0)
                Console.WriteLine("\nNumber is Even");
            else
                Console.WriteLine("\nNumber is Odd");
        }
        public void testGreater()
        {
            int a=45, b=78, c=22;            
            
            if (a > b && a > c)
                Console.WriteLine("a is Greater than b and c");
            else if (b > a && b > c)
                Console.WriteLine("b is Greater than a and c");
            else if (c > a && c > a)
                Console.WriteLine("c is Greater than a and b");
        }
    }

}