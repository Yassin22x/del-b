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
    public void Enroll(Student student)  // Metod för att skicka in en elev på kursen
    {
        if (student == null|| Students.Contains(student))  // Om eleven inte finns eller redan går kursen, så gör vi ingenting
            return;

            Students.Add(student);  // Sparar eleven i kursens egna lista
            student.Join(this);  // Anropar studenten så att den också lägger till kursen i sin lista (tvåvägskoppling)

    }

    public void Remove(Student student)  // Metod för att ta bort en elev från kursen
    {
        if (student == null || !Students.Contains(student))  // Om eleven inte finns eller inte går kursen, så gör ingenting
            return;

            Students.Remove(student);  // Tar bort eleven från kursens lists
    }
}