
// C# program to illustrate do-while loop 
using System;

class DoWhileDemo
{
    public void testDoWhile()
    {
        int x = 21;
        Console.WriteLine();
        do
        {
            Console.WriteLine("Do...while loop");
            x--;
        }
        while (x > 21);
    }
}