using System;

class Program
{
    static void Main()
    {
        // 1. Skapar en kurs och några studenter med helt egna namn
        Course datateknik = new Course("Programmering 1", 3);
        Student liam = new Student("Liam");
        Student astrid = new Student("Astrid");
        Student oskar = new Student("Oskar");

        // 2. Registrerar studenter på olika sätt för att testa systemet
        datateknik.Enroll(liam);
        astrid.Join(datateknik);

        // 3. Testar vad som händer när vi lägger till fler än max antal platser
        datateknik.Enroll(oskar); // Ska fungera (3/3 platser)
        
        Student extraElev = new Student("Noa");
        datateknik.Enroll(extraElev); // Ska visa att kursen är full

        // 4. Testar dubbletthantering (försöker lägga till Liam igen)
        liam.Join(datateknik); 

        // 5. Skriver ut information och listor
        Console.WriteLine("\n--- Kursstatus ---");
        Console.WriteLine(datateknik); // Visar namn och platser

        Console.WriteLine();
        datateknik.RollCall(); // Visar alla som går kursen

        Console.WriteLine();
        liam.Schedule(); // Visar Liams schema

        // 6. Testar avanmälan och att ta bort någon som inte finns
        Console.WriteLine("\n--- Testar avanmälan ---");
        astrid.Leave(datateknik); // Astrid hoppar av
        Console.WriteLine(datateknik); // Visar uppdaterat antal platser

        datateknik.Remove(extraElev); // Testar att ta bort en elev som inte är med (ska inte krascha)
    }
}