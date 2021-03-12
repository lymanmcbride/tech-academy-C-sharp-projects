using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        //Declare Arrays and lists below
        string[] names = { "Lyman", "Charlie", "Lucy", "Brenda", "Chazdidee" };
        int[] integers = { 99, 98, 97, 96, 95, 94, 93, 92, 91 };

        List<string> favNames = new List<string>();
        favNames.Add("Georgia");
        favNames.Add("Peter");
        favNames.Add("Gemma");
        favNames.Add("Dietmar");
        favNames.Add("Lars");
        favNames.Add("Joseph");
        favNames.Add("Stephanie");

        int favNames_maxIndex = favNames.Count - 1; //this is different from .length for arrays


        //Console App:
        //Get input for array of names
        Console.WriteLine("Hello, we have an array of names, an array of integers, and a list of names." +
            "\nLet's start with the first array of names. Pick an index between 0 and 4");
        int names_choice = Convert.ToInt32(Console.ReadLine());

        //The if statement checks for an out of range index. the else if statement will return the value at their index. 
        //It's not in an else statement so that the program can continue if they did it wrong
        //This is the structure for all three questions.
        if (names_choice > names.Length - 1 || names_choice < 0)
        {
            Console.WriteLine("You chose an index that doesn't exist. Too bad!");
            Console.ReadLine();
        }
        else if (names_choice <= names.Length - 1 && names_choice >= 0)
        {
            Console.WriteLine("Your chosen value is: " + names[names_choice]);
        }

        Console.WriteLine("\nOk, now let's get an integer from our integer array." +
            "\nPick an index between 0 and 8");
        int integers_choice = Convert.ToInt32(Console.ReadLine());

        if (integers_choice > integers.Length - 1 || integers_choice < 0)
        {
            Console.WriteLine("You chose an index that doesn't exist. Too bad!");
            Console.ReadLine();
        }
        else if (integers_choice <= integers.Length - 1 && integers_choice >= 0)
        Console.WriteLine("Your Chosen integer from the array is: " + integers[integers_choice]);
        Console.WriteLine("\nOk, now finally let's get your index for the list of favorite baby names." +
            "\nPick an index between 0 and " + favNames_maxIndex);
        int favNames_choice = Convert.ToInt32(Console.ReadLine());

        if (favNames_choice > favNames_maxIndex || favNames_choice < 0)
        {
            Console.WriteLine("You've chosen an index that's out of range! Too bad!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your chosen name out of the list is: " + favNames[favNames_choice]);
            Console.ReadLine();
        }





    }
}
