
using System;

// Class Declaration 
public class Doctor
{

    // Instance Variables 
    String name;
    String speciality;
    int age;
    String city;

    // Constructor Declaration of Class 
    public Doctor(String name, String speciality,
                  int age, String city)
    {
        this.name = name;
        this.speciality = speciality;
        this.age = age;
        this.city = city;
    }

    // method 1 
    public String getName()
    {
        return name;
    }

    // method 2 
    public String getSpeciality()
    {
        return speciality;
    }

    // method 3 
    public int getAge()
    {
        return age;
    }

    // method 4 
    public String getCity()
    {
        return city;
    }

    public String toString()
    {
        return ("\nHi! my name is Dr. " + this.getName()
                + ".\nMy speciality is "+ this.getSpeciality()+", age and city are" 
                + ", " + this.getAge() + ", " + this.getCity());
    }

}