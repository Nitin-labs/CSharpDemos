using System;
namespace CSharp
{
    class WhileDemo
    {
        public void testWhileDemo()
        {
            int x = 1;
            Console.WriteLine("\nWhileDemo");
            // Exit when x becomes greater than 4 
            while (x <= 5)
            {
                Console.WriteLine("Count " + x);
                x++;
            }
        }
    }
}