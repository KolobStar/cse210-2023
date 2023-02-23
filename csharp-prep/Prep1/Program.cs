//Gloria EStrella prep 1 from my lap

using System;

class Program
{
    static void Main(string[] args)
    {
        //Si solo pones console.write vas a poder poner el input al lado de la pregunta
        Console.Write ("What's your first name? ");
        string first = Console.ReadLine();


        Console.Write ("What's your last name? ");
        string last = Console.ReadLine();

        //el$ ayuda a que ahi mismo puedas poner los estrings con variables
        Console.WriteLine($"Your name is {last}, {first} {last}");

    }
}