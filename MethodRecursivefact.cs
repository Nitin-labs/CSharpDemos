using System;
namespace CSharp{
    class MethodRecursiveFact{
        public int factorial(int n){
            int result;
            if(n==1){
                return 1;
            }else {
                result=factorial(n-1)*n;
                return result;
            }
        }
        public void testFactorial(){
            MethodRecursiveFact mf=new MethodRecursiveFact();
            Console.WriteLine("\nFactorial of 15 is: {0}",mf.factorial(15));
        }
    }
}
