using System; 
  
// Outer class 
public class OuterClass { 
  
    // Method of outer class 
    public void method1() 
    { 
        Console.WriteLine("\nI'm in Outer Class "); 
    } 
  
    // Inner class 
    public class InnerClass { 
  
        // Method of inner class 
        public void method2() 
        { 
            Console.WriteLine("I'm in Inner Class"); 
        } 
    } 
} 
  
// Driver Class 
public class NestedClass { 
  
    // Main method 
    public void testNestedClass() 
    { 
  
        // Create the instance of outer class 
        OuterClass outer = new OuterClass(); 
        outer.method1(); 
  
        // This statement gives an error because 
        // you are not allowed to access inner  
        // class methods with outer class objects 
        // obj1. method2(); 
  
        // Creating an instance of inner class 
        OuterClass.InnerClass iner = new OuterClass.InnerClass(); 
  
        // Accessing the method of inner class 
        iner.method2(); 
    } 
} 