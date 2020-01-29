using System;
namespace CSharp{
    class Super{
        public virtual void SuperTest(){
            Console.WriteLine("\nSuper Test method called");
        }
        public void SuperShow(){
            Console.WriteLine("\nSuper show method called");
        }
    }
    class PolymorMethodOverride:Super{
        public override void SuperTest(){
            Console.WriteLine("Overided method called by child");
        }
        public void testPolymorphism(){
        PolymorMethodOverride pmo=new PolymorMethodOverride();
        pmo.SuperShow();
        pmo.SuperTest();
        }
        
    }
}