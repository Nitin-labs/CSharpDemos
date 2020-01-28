using System;

namespace CSharp
{

    static class MethodExtension2
    {

        // Method 4 
        public static void test4(this MethodExtension1 m)
        {
            Console.WriteLine("\nTest 4");
        }

        // Method 5 
        public static void test5(this MethodExtension1 m, string str)
        {
            Console.WriteLine("Test 5:" + str);
        }
        public static string toProper(this string oldStr)
        {
            string newStr = null;
            if (oldStr.Trim().Length > 0)
            {
                oldStr = oldStr.ToLower();
                string[] str = oldStr.Split(' ');
                foreach (string item in str)
                {
                    char[] charAr = item.ToCharArray();
                    charAr[0] = Char.ToUpper(charAr[0]);
                    if (newStr == null)
                        newStr = new string(charAr);
                    else
                        newStr += " " + new string(charAr);
                }
                return newStr;
            }
            return oldStr;
        }

    }
}