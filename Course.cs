using System;
using System.Collections.Generic;

public class Course
{
    public string Name { get; set; }  // Håller koll på kursens namn
    public int MaxSeats { get; set; }  //Håller koll på max antal platser på kursen

    public List<Student> Students { get; set; } = new List<Student>();  // En tom lista där vi sparar alla elever som går kursen

    public Course(string name, int maxSeats)  // Sätter namn och max antal platser när kursen skapas
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public override string ToString()   // Gör så att kursens namn visas när vi skriver ut kursen på skärmen
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";  // Visar kursens namn, antal elever som går kursen och max antal platser
    }
    public void Enroll(Student student)  // Metod för att skicka in en elev på kursen
    {
        if (student == null|| Students.Contains(student))  // Om eleven inte finns eller redan går kursen, så gör vi ingenting
            return;

        if (Students.Count >= MaxSeats)  // Om kursen är full, så gör vi ingenting
        { 
            Console.WriteLine("Kursen är tyvärr full"); // Skriver ut meddelande
            return; // Avbryter så eleven inte läggs till
        }
            Students.Add(student);  // Sparar eleven i kursens egna lista
            student.Join(this);  // Anropar studenten så att den också lägger till kursen i sin lista (tvåvägskoppling)

    }

    public void Remove(Student student)  // Metod för att ta bort en elev från kursen
    {
        if (student == null || !Students.Contains(student))  // Om eleven inte finns eller inte går kursen, så gör ingenting
            return;

            Students.Remove(student);  // Tar bort eleven från kursens lists
            student.Leave(this);  // Anropar studenten så att den också tar bort kursen (tvåvägskoppling)
    }
    public void RollCall() // Metod för att skriva ut alla elever i kursen
    {
        Console.WriteLine($"Deltagare i {Name}:"); // Skriver ut rubrik med kursens namn
        if (Students.Count == 0) // Om inga elever går kursen
        {
            Console.WriteLine("  Inga studerande anmälda."); // Meddelar att listan är tom
            return; // Avbryter metoden
        }

        foreach (var student in Students) // Går igenom varje elev i listan
        {
            Console.WriteLine($"  - {student.Name}"); // Skriver ut elevens namn
        }
    }
}