using System;
namespace CSharp{
    class PlanetEarth{
        protected string name;
        public PlanetEarth(){
            name="Earth";
            
        }
    }
    class satelliteMoon:PlanetEarth{
        public string getName(){
            return name;
        }
    }
    class AccessModifiersProtected{
        public void testProtected(){
            PlanetEarth p=new PlanetEarth();
            satelliteMoon s=new satelliteMoon();

            Console.WriteLine("\nYour on Planet: {0}",s.getName());
        }
    }
}