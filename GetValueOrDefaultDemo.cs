// Program to use of "GetValueOrDefault()" method 
//The Nullable<T> type has a GetValueOrDefault(T) method that behaves in a way identical to the ?? operator.  
//It returns the value of the object, if non-null, or the value of the parameter passed in if the object is null.

using System;
namespace CSharp{
    class GetValueOrDefaultDemo{
        public void testGetValueOrDefault(){
            Nullable<int> num1=null;
            Console.WriteLine(num1.GetValueOrDefault());
            int ? num2=null;
            Console.WriteLine(num2.GetValueOrDefault());
            int ? num3=32;
            Console.WriteLine(num3.GetValueOrDefault());
            Nullable<int> num4=888;
            Console.WriteLine(num4.GetValueOrDefault());  
            Nullable<int> pocketMoney = null;
 
            int mood2 = pocketMoney ?? 500;   // result = 500, since pocketMoney is null
            int mood3 = pocketMoney.GetValueOrDefault(500);   // same as above      
            Console.WriteLine("Rs."+mood2);
            Console.WriteLine("Rs."+mood3);
        }
    }
}