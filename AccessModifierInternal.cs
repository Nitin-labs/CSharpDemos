using System;
namespace CSharp
{
    internal class InternalDemo
    {
        int productId;
        string productName;
        public void setData(int pi, string pn)
        {
            productId = pi;
            productName = pn;
        }
        public void displayData()
        {
            Console.WriteLine("Product Id: {0}", productId);
            Console.WriteLine("Product Name: {0}", productName);
        }
    }
    class AccessModifiersInternal
    {
        public void testInternal()
        {
            InternalDemo i =  new InternalDemo();
            Console.WriteLine();
            i.setData(105, "Vostro 15 3000");
            i.displayData();
        }
    }
}