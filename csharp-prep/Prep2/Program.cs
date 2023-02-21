using System;

class Program
{
    static void Main(string[] args)
    {       
        //This is prep 2
        //Consolo.write helps to put the input next to the question
        Console.Write("What is your grade persentage? ");
        //This helps to read the string answer
        string answer = Console.ReadLine(); 
        int percent = int.Parse(answer);

        string letter = "";

        if ( percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
         else if (percent >= 70)
        {
            letter = "C";
        }
         else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter= "F";
        }
        // The $ helps to add a string in the line 
        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better Luck next time!");
        }

            

    }
}