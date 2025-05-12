using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // Läser in antal heltal som ska hanteras

        for (int i = 0; i < n; i++) // Loopar igenom alla heltal
        {
            int x = int.Parse(Console.ReadLine()); // Läser in ett heltal
            if (x % 2 == 0) // Kollar om talet är jämnt
                Console.WriteLine(x + " is even"); // Skriver ut att talet är jämnt
            else 
                Console.WriteLine(x + " is odd"); // Annars skrivs det ut att talet är udda
        }
    }
}
//läser in ett antal rader. För varje rad, läser ett heltal och avgör om det är jämnt eller udda. Sen skriver ut resultatet.