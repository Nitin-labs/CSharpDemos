using System;
class SDCard{
    private string memory;
    public void setData(string s){
        memory=s;
    }
    public void display(){
        Console.WriteLine("Memory size is: "+memory);
    }
    public SDCard Sandisk(SDCard sd){
        SDCard sdc=new SDCard();
        sdc.memory=memory+sd.memory;
        return sdc;
    }
}
class MethodReturngObject{
    public void testSDCard(){
        SDCard m1=new SDCard();
        SDCard m2=new SDCard();

        m1.setData("4 GB ");
        m2.setData("8 GB ");

        SDCard m3=m1.Sandisk(m2);

        m1.display();
        m2.display();
        m3.display();
    }
}