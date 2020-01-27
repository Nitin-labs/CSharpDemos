using System;
namespace CSharp{
    public delegate string japaneseGreetDeleg(string name);
    class MethodAnnonymous{
        // public string japaneseGreet(string name){
        //     return "Kon/'nichiva "+name+"! Ohayōgozaimasu ";
        // }
        public void testAnnonymous(string name){
            japaneseGreetDeleg j=delegate(string name){
                return "\nKon'nichiva "+name+"! Ohayōgozaimasu ";        
            };
            string greet=j(name);
            Console.WriteLine(greet);
        }
    }
}