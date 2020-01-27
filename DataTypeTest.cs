using System; 
namespace  CSharp{ 
      
class DataTypeTest { 
      
    public void testDataType() 
    { 
          
        char ch = 'G'; 
  
        int i = 89; 
  
        short sh = 56; 
         
        long l = 4564; 
  
        uint ui = 95; 
  
        ushort us = 76; 
        
        ulong ul = 3624573; 
  
        double d = 8.358674532; 
  
        // for float use 'f' as suffix 
        float f = 3.7330645f; 
  
        // for float use 'm' as suffix 
        decimal dec = 389.5m; 
        Console.WriteLine("\nTesting DataTypes");
  
        Console.WriteLine("char: " + ch+" Type: "+typeof(char)); 
        Console.WriteLine("integer: " + i+" Type: "+typeof(int)); 
        Console.WriteLine("short: " + sh+" Type: "+typeof(short)); 
        Console.WriteLine("long: " + l+" Type: "+typeof(long)); 
        Console.WriteLine("float: " + f+" Type: "+typeof(float)); 
        Console.WriteLine("double: " + d+" Type: "+typeof(double)); 
        Console.WriteLine("decimal: " + dec+" Type: "+typeof(decimal)); 
        Console.WriteLine("Unsinged integer: " + ui+" Type: "+typeof(uint)); 
        Console.WriteLine("Unsinged short: " + us+" Type: "+typeof(ushort)); 
        Console.WriteLine("Unsinged long: " + ul+" Type: "+typeof(ulong)+"\n"); 
    } 
} 
}