using System; 
namespace CSharp{  
public class SwitchDemo  
{ 
    public void testSwitch() 
    { 
        int number = 30; 
        Console.WriteLine("\nSwitch Demo:");
        switch(number) 
        { 
        case 10: Console.WriteLine("case 10"); 
                 break; 
        case 20: Console.WriteLine("case 20"); 
                 break; 
        case 30: Console.WriteLine("case 30"); 
                 break; 
        default: Console.WriteLine("None matches");  
                 break; 
        } 
    } 
}
}