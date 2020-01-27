using System;
namespace CSharp
{
    public delegate void squaredelegate(int sq);
    public delegate void cubedelegate(int cu);
    class MethodDelegateMulticast
    {
        public void square(int i)
        {
            Console.WriteLine("Square : " + (i * i));
        }
        public void cube(int j)
        {
            Console.WriteLine("Cube : " + (j * j * j));
        }

        public void testMulticast(int p)
        {
            MethodDelegateMulticast mdm = new MethodDelegateMulticast();
            squaredelegate deleg = mdm.square;  // --> equaivalent to squaredelegate deleg=new squaredelegate(mdm.square)
            deleg += mdm.cube;                  // Multicast as both methods has same no. of parameters and return type, so it calls both method
            Console.WriteLine("\nMulticast Delegates");
            deleg(p);

        }
    }
}