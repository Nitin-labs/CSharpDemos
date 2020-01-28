using System; 
  
class ForEachDemo { 
  
    // Main Method 
    public void testForEach() 
    { 
  
        Console.WriteLine("\nPrint Technologies using foreach:"); 
  
        string[] a_array = new string[] {"Servlets","Spring","Hibernate","Strut" }; 
  
        // foreach loop begin it will run till the last element of the array 
        foreach(string items in a_array) 
        { 
            Console.WriteLine(items); 
        } 
    } 
} 