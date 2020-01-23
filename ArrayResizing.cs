using System;
namespace CSharp{
    public class ArrayResizing{
        public void testArrResize(){
            int[] arr=new int[3]{2,3,4};
            Console.WriteLine("Array before resize: ");
            foreach(int i in arr){
                Console.Write(i+" ");
            }
            int newSize=8;
            Array.Resize(ref arr,newSize);
            Console.WriteLine("\nArray after Resizing: ");
            foreach(int i in arr){
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}