using System;
namespace CSharp{
    class MethodLongestString{
        public string findLongest(string s1,string s2){
            string result;
            if(s1.Length>s2.Length)
                result= s1;
            else
                result=s2;

            return result;
        }
        public void testFindLongest(){
            string blackPantherCity="wakanda";
            string batmanCity="Gotham";
            string famousCity;
            MethodLongestString ml=new MethodLongestString();
            famousCity=ml.findLongest(blackPantherCity,batmanCity);
            Console.WriteLine("\nFamous City: {0}",famousCity);
        }
    }
}