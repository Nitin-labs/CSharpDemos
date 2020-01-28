using System; 
namespace CSharp{
class KeywordThrow { 
      
     static string sub = null; 
          
    // method to display subject name     
    static void displaysubject(string sub1) 
    { 
        if (sub1  == null) 
            throw new NullReferenceException("Exception Message"); 
              
    } 
  
public void testThrow() 
{ 
      
    // using try catch block to handle the Exception 
    try
    {           
        // calling the static method 
        displaysubject(sub); 
    } 
      
    catch(Exception exp) 
    { 
        Console.WriteLine(exp.Message ); 
    }                      
} 
  
} }