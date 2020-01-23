using System;
namespace CSharp{
    class VariableScope{
        int classVariable=45;
        public void testVariableScope(){
            Console.WriteLine("\nClass level Variable: "+classVariable);
            int methodVariable=55;
            Console.WriteLine("Method level variable: "+methodVariable);
            for(int i=0;i<4;i++){
                Console.WriteLine("Block level Variable: "+i);
            }
        }
    }
}