using System;
namespace CSharp{
    partial class MethodPartial
    {
        // Comment out this method and the program
        // will still compile.
        partial void OnSomethingHappened(string s)
        {
            Console.WriteLine("Something happened: {0}", s);
        }
    }
}