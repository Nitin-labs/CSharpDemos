using System;
namespace CSharp{
    interface IAlexa
    {
        void call();
    }
    interface IGoogleAssistant
    {
        void call();

    }
    class InterfaceMultipleInherit:IAlexa,IGoogleAssistant{
        void IAlexa.call(){
            Console.WriteLine("Alexa Calling");
        }
        void IGoogleAssistant.call(){
            Console.WriteLine("Google Assistent Calling");
        }
        public void testMultipleInheritance(){
            InterfaceMultipleInherit imi=new InterfaceMultipleInherit();
            IAlexa ia=imi;
            IGoogleAssistant iga=imi;
            Console.WriteLine("\n---**Multiple Inheritance**---");
            ia.call();
            iga.call();
        }
    }
}