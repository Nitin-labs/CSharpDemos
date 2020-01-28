using System;
namespace CSharp{
    class Wwww{
        public Wwww(){
            Console.Write("\nwww.");
        }
    }
    class Yahoo:Wwww{
        public Yahoo(){
            Console.Write("yahoo.");
        }
    }
    class com:Yahoo{
        public com(){
            Console.Write("com");
        }
    }
    class InheritMultilevel{
        public void testMultilevelInherit(){
        com c=new com();                  
        }
    }
}