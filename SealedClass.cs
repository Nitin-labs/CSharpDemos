// C# code to define a Sealed Class which can not be inherited 
using System; 
  
// Sealed class 
sealed class SealedClass { 
  
    // Calling Function 
    public void sun() 
    { 
        Console.WriteLine("\n\nYou can't derive me") ;
    } 
} 
  
class SealedClassDemo { 
  
    // Main Method 
    public void testSealedClass() 
    { 
  
        // Creating an object of Sealed Class 
        SealedClass slc = new SealedClass(); 
  
        slc.sun(); 
    } 
} 