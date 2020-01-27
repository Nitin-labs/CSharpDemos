using System
;
namespace CSharp
{
    class Box
    {

    }
    class Cylinder
    {

    }
    class KeywordIs
    {
        public void testIsKeyword()
        {
            Box b = new Box();
            Cylinder c = new Cylinder();

            bool check = b is Box;
            Console.WriteLine("\nIs b is Box object ? {0}", check);
            check = c is Cylinder;
            Console.WriteLine("Is c is Cylinder object ? {0}", check);
            b = null;

            check = b is Box;
            Console.WriteLine("Is b is Box object ? {0}", check);

        }
    }
}