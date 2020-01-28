using System;
namespace CSharp
{
    public interface Honda
    {
        public void HondaMsg();
                

    }
    public interface City{
    public void CityMsg();

    }
    class HondaCity : Honda, City
    {
        public void HondaMsg()
        {
            Console.Write("Honda Engine ");
        }
        public HondaCity()
        {
            Console.WriteLine("\n\nHondacity Model");
        }
        public void CityMsg()
        {
            Console.Write(": City Body");
        }
    }
    class InheritMutiple
    {
        public void testMultipleInherit()
        {
            HondaCity hc = new HondaCity();
            hc.HondaMsg();
            hc.CityMsg();
            
        }
    }
}