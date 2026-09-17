using System;
using System.Collections.Generic;

public class Course
{
    public string Name { get; set; }  // Håller koll på kursens namn

    public List<Student> Students { get; set; } = new List<Student>();  // En tom lista där vi sparar alla elever som går kursen

    public Course(string name)  // Sätter namnet på kursennär vi skapar den
    {
        Name = name;
    }

    public override string ToString()   // Gör så att kursens namn visas när vi skriver ut kursen på skärmen
    {
        return Name;
    }
    
}