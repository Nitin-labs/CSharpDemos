using System;
namespace CSharp
{
    class TwoDArray{
        public void testTwoD(){
            int [,] arrayTwoD=new int[3,3]{{12,13,14},{23,24,25},{34,35,36}};
            for(int i=0;i<3;i++){
                for(int j=0;j<3;j++){
                    Console.Write(arrayTwoD[i,j]+" ");
                }
                Console.WriteLine("");
            }
        }
    }
    
}