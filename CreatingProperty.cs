using System;
namespace CSharp{
    public class Train{
        public int _trainId;
        public string name,source,dest;
        public Train(int trainId,string name,string source, string dest ){
            _trainId=trainId;
            this.name=name;
            this.source=source;
            this.dest=dest;
        }
    }
    class CreatingProperty{
        public void testProperty(){
            Train t1=new Train(11014,"Lokmanya Tilak Turminas","Mumbai","Coimbatore");
            Console.WriteLine("\n---**CreatingProperty**---");
            Console.WriteLine("Train Info\n"+t1._trainId+" "+t1.name+" "+t1.source+" "+t1.dest);
            
        }
    }
}