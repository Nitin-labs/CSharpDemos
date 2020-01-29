// C# program to illustrate encapsulation 
using System;

public class PatientInfo
{

    // private variables declared these can only be accessed by 
    // public methods of class 
    private String patientName;
    private int patientAge;

    public String Name
    {

        get
        {
            return patientName;
        }

        set
        {
            patientName = value;
        }

    }

    public int Age
    {

        get
        {
            return patientAge;
        }

        set
        {
            patientAge = value;
        }

    }


}

// Driver Class 
class EncapsulationDemo
{

    // Main Method 
    public void testEncapsulation()
    {

        // creating object 
        PatientInfo obj = new PatientInfo();

        obj.Name = "Ankita";        // calls set accessor of the property Name, and pass "Ankita" 

        obj.Age = 21;               // calls set accessor of the property Age,  and pass "21"

        // Displaying values of the variables 
        Console.WriteLine("\n---**Encapsulation**---");
        Console.WriteLine("Patient Name: " + obj.Name);
        Console.WriteLine("Patient Age: " + obj.Age);
    }
}