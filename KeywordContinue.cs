// C# program to demonstrate continue statement 
using System; 
  
class KeywordContinue
{ 
    public void testContinue() 
    {     
        for(int i = 1; i < 3; i++) 
        { 
            if(i == 2) 
              continue; 
              
            Console.WriteLine("\nContinue Test");  
        } 
    } 
}