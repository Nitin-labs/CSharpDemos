using System;
namespace CSharp
{
    public class ArrayDemo
    {
        public void test()
        {
            int [] array1=new int[4]{11, 22, 33, 44};
            Console.WriteLine("Elemenets of array are: ");
            for(int i=0;i<4;i++)            
                Console.Write(array1[i]+" ");  
            Console.WriteLine();
            foreach(int i in array1){
                Console.Write(i+" ");
            }  
            Console.WriteLine();

            
        }
    }
}