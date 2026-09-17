using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }  // Håller koll på vad eleven heter

    public List<Course> Courses { get; set; } = new List<Course>();  //En tom lista där vi sparar alla kurser eleven går i

    public Student(string name)  // Sätter namnet på eleven nör vi skapar den
    {
        Name = name;
    }

    public override string ToString()  // Gör så att elevens namn visas när vi skriver ut eleven på skärmen
    {
        return Name;


    }

}
