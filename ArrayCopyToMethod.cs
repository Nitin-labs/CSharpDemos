using System;
namespace CSharp{
    class ArrayCopyToMethod{
        public void copyToMethod(){
            int[] first=new int[2]{33,55};
            int[] second=new int[5]{11,22,44,66,77};
            Console.WriteLine("Before Copy To method: ");
            Console.WriteLine("first Array:");
            foreach(int i in first){
                Console.Write(i+" ");
            }
            Console.WriteLine("\nsecond Array:");
            foreach(int i in second){
                Console.Write(i+" ");
            }
            Console.WriteLine("\nAfter Copy To method: ");
            first.CopyTo(second,2);
            foreach(int i in second){
                Console.Write(i+" ");
            }            
        }
    }
}