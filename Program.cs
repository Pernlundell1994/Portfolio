// See https://aka.ms/new-console-template for more information
using System;
namespace Protfolio;
static class Program
{

    static void Main(){
        ShowConcat();
        //SelectChoice();
    }

    static private void SelectChoice()
    {
        Console.WriteLine("Hi Jesse, how are you today?");

        Console.WriteLine("(A) - Good");
        Console.WriteLine("(B) - Bad");
        Console.WriteLine("(C) - Idk");
        Console.WriteLine();
        var choice = Console.ReadLine(); //dfference between function and procedure

        HandleChoice(choice);
    }
    static private void HandleChoice(string? choice) //can initialize variable within parameters to be returned
    {                                               //how to clear text on console app
        switch (choice)
        {
            case "A":
                Console.WriteLine("Yeah Man!");
                break;
            case "B":
                Console.WriteLine("Not Good Man");
                break;
            case "C":
                Console.WriteLine("Idk Man");
                break;
            default:
                Console.WriteLine("Please input a correct reponse.");
                SelectChoice();
                    break;
        }   
    }
    static private void ShowConcat()
    {
        string firstSymbol = "$$";
        string lastSymbol = "USD";
        int benjamin = 100;
        string wallet = string.Concat(firstSymbol, " ", benjamin, " ", lastSymbol); //why did the plus sign work but not comma?
        Console.WriteLine(wallet);
    }
}
