
// C# program to illustrate the 
// use of goto in switch statement 
using System;
namespace CSharp
{
    public class SwitchWithGoto
    {

        // Main Method 
        public void testSwitchGoto()
        {
            int car = 3;

            switch (car)
            {
                case 1:
                    Console.WriteLine("\nHonda city");
                    goto default;
                case 2:
                    Console.WriteLine("\nTavera");
                    goto case 3;
                case 3:
                    Console.WriteLine("\nVolks Wagon");
                    goto default;
                default:
                    Console.WriteLine("Entered value is: " + car);
                    break;
            }
        }
    }
}