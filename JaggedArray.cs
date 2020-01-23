using System;
namespace CSharp{
    class JaggadArray{
        public void testJagArr(){
            int [][] arrJag=new int[2][];
            arrJag[0]=new int[3]{20,13,56};
            arrJag[1]=new int[2]{98,36};
            Console.WriteLine("Jagged Array: ");
            for(int i=0;i<2;i++){
                for(int j=0;j<arrJag[i].Length;j++){
                    Console.Write(arrJag[i][j]+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}