// See https://aka.ms/new-console-template for more information
using EdhouseConsole;
using System.Security.Claims;

Console.WriteLine("Smajlici vytvoreni.");

Console.WriteLine("Tvorba hernich polí.");
List<Smajlici> HraciPole = new List<Smajlici>();
HraciPole.Add(new Smajlici(new Smajlik("Red", ")"), new Smajlik("Yellow", ")"), new Smajlik("Red", ":"), new Smajlik("Green", ":"), 1));
HraciPole.Add(new Smajlici(new Smajlik("Blue", ":"), new Smajlik("Yellow", ":"), new Smajlik("Blue", ")"), new Smajlik("Green", ")"), 2));
HraciPole.Add(new Smajlici(new Smajlik("Red", ":"), new Smajlik("Yellow", ":"), new Smajlik("Blue", ")"), new Smajlik("Yellow", ")"), 3));

HraciPole.Add(new Smajlici(new Smajlik("Red", ")"), new Smajlik("Blue", ":"), new Smajlik("Green", ":"), new Smajlik("Red", ")"), 4));
HraciPole.Add(new Smajlici(new Smajlik("Blue", ":"), new Smajlik("Green", ":"), new Smajlik("Red", ")"), new Smajlik("Yellow", ")"), 5));
HraciPole.Add(new Smajlici(new Smajlik("Blue", ")"), new Smajlik("Yellow", ")"), new Smajlik("Red", ":"), new Smajlik("Green", ":"), 6));

HraciPole.Add(new Smajlici(new Smajlik("Blue", ")"), new Smajlik("Green", ")"), new Smajlik("Yellow", ":"), new Smajlik("Blue", ":"), 7));
HraciPole.Add(new Smajlici(new Smajlik("Blue", ":"), new Smajlik("Red", ")"), new Smajlik("Blue", ")"), new Smajlik("Yellow", ":"), 8));
HraciPole.Add(new Smajlici(new Smajlik("Yellow", ":"), new Smajlik("Red", ")"), new Smajlik("Green", ")"), new Smajlik("Green", ":"), 9));
Console.WriteLine("Herni pole vytvoreno.");

Console.WriteLine("Reseni hlavolamu");
List<Smajlici> vyr = new List<Smajlici>();
Hlavolam.Reseni(HraciPole, vyr, 3, 3);
Console.WriteLine("Hlavolam vyresen");
if (vyr.Count == 9)
{
    foreach (Smajlici smajl in vyr)
    { 
        Console.WriteLine($"Pole:{smajl.pole_cislo} -> otoceni:{smajl.otoceni}"); 
    }
}
else
{
    Console.WriteLine("Uloha nena reseni");
}