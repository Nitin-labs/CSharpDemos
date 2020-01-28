using System;
namespace CSharp{
    class FileInfo{
        public FileInfo(){
            Console.WriteLine("\nFile Description");
        }
        public void fileCreation(){
            Console.WriteLine("File created");
        }
        public void writeFile(){
            Console.WriteLine("Writing in file");
        }
    }
    class InheritanceDemo:FileInfo{
        public void testInheritance(){
            FileInfo fi=new FileInfo();
            fi.fileCreation();
            fi.writeFile();
        }
    }
}