using System;
namespace CSharp
{
    class AddMatrix
    {
        int a, b, c, d;
        public AddMatrix(int a, int b, int c, int d)
        {
            this.a = a; this.b = b; this.c = c; this.d = d;
        }

        public static AddMatrix operator +(AddMatrix m1, AddMatrix m2)
        {
            AddMatrix result = new AddMatrix(m1.a + m2.a, m1.b + m2.b, m1.c + m2.c, m1.d + m2.d);
            return result;
        }
        public override string ToString(){
            return a+" "+b+"\n"+c+" "+d+"\n";
        }
    }
    class PolymorOperatorOverloading
    {
        public void testOperatorOveloading()
        {
            AddMatrix m1 = new AddMatrix(10, 20, 30, 40);
            AddMatrix m2 = new AddMatrix(30, 60, 90, 10);
            AddMatrix m3 = m1 + m2;
            Console.WriteLine();
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());
            Console.WriteLine(m3.ToString());
            
        }
    }
}