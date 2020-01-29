using System;
namespace CSharp{
    class Temp{
        public virtual void show(){
            Console.WriteLine("\nTemp show method is called");
        }
        public virtual void test(){
            Console.WriteLine ("Test mehtod is called");
        }

    }
    class PolymorMethodHiding:Temp{
        //Method hiding
        public new void show(){
            Console.WriteLine("\nMethod hiding is done successfully");
        }
        //method overrided
        public override void test(){
            Console.WriteLine("Overrided method is called ");
        }
        public void testMethodHiding(){
            PolymorMethodHiding pmh=new PolymorMethodHiding();
            pmh.show();
            pmh.test();
        }
    }

}