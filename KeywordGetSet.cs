using System;
namespace CSharp{
    public class Laptop{
        private string name="Dell";
        public string Name{
            get{
                return name;
            }
            set{
                name=value;
            }
        }
    }
    class KeywordGetSet{
        public void testGetSet(){
        Laptop lap1=new Laptop();
        lap1.Name="Lenovo";
        Console.WriteLine("\nUSe of get and set\nName: "+lap1.Name);
        int get=23000;
        int set=30000;
        Console.WriteLine("Value of get is: {0}",get);
        Console.WriteLine("Value of set is: {0}",set);
        }
    }
}