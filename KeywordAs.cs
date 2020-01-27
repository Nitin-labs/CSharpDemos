using System;
using System.Collections.Generic;
namespace CSharp
{
    class KeywordAs
    {
        public void testAsKeyword()
        {
            string str1 = "Microsoft";
            object obj1 = str1;
            string str2 = obj1 as string;
            if (str2 != null)
            {
                Console.WriteLine("\nSuccessfully Casted");
            }
            List<string> mylist = obj1 as List<string>;
            if (mylist != null)
            {
                Console.WriteLine("Successfully Casted");
            }
            else
            {
                Console.WriteLine("Not Successfull");
            }
        }
    }
}