using System;
namespace CSharp
{
    class EmpDetails
    {
        public int empId;
        public string empName;

        public EmpDetails(int e, string n)
        {
            empId = e;
            empName = n;
        }

        public int getEmpId()
        {
            return empId;
        }
        public string getName()
        {
            return empName;
        }
    }
    class AccessModifierPublic
    {
        public void testPublic()
        {
            EmpDetails emp1=new EmpDetails(202,"John Vostro");
            Console.WriteLine("Employee Id: {0}",emp1.empId);
            Console.WriteLine("Name: {0}",emp1.empName);
            Console.WriteLine();

            Console.WriteLine("Employee Id: {0}",emp1.getEmpId());
            Console.WriteLine("Employee Name: {0}",emp1.getName());            
        }
    }
}