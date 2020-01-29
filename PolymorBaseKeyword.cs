using System;
namespace CSharp{
    class Parent{
        public virtual void display(){
            Console.WriteLine("\ndisplay method is called by base keyword");
        }
        public virtual void trial(){
            Console.WriteLine ("trial mehtod is called by base keyword");
        }

    }
    class PolymorBaseKeyword:Parent{
        //Method hiding
        public new void display(){
            Console.WriteLine("\nMethod hiding using new keyword");
        }
        //method overrided
        public override void trial(){
            Console.WriteLine("Overriding method using override keyword ");
        }
        public void testBaseKeyword(){
            PolymorBaseKeyword pmh=new PolymorBaseKeyword();
            pmh.display();
            pmh.trial();
            base.display();              // called with base keyword, calling to parent class method
            base.trial();
        }
    }

}