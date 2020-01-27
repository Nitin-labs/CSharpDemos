using System; 
   
namespace CSharp { 
   
// Here Geek class contains three methods 
// Now we want to add two more new methods in it  
// Without re-compiling this class 
class MethodExtension1 { 
   
  // Method 1 
  public void test1()  
  { 
      Console.WriteLine("Test 1"); 
  } 
   
  // Method 2 
  public void test2() 
  { 
      Console.WriteLine("Test 2"); 
  } 
   
  // Method 3 
  public void test3() 
  { 
      Console.WriteLine("Test 3"); 
  }     
 }      
} 