// See https://aka.ms/new-console-template for more information
using System;

class Program{

    static public void Main(){
        Console.WriteLine("Hi Jesse, how are you today?");

        Console.WriteLine("(A) - Good");
        Console.WriteLine("(B) - Bad");
        Console.WriteLine("(C) - Idk");
        Console.WriteLine();
        Console.ReadLine();

        Program.choiceLoop();
    }

    static private void choiceLoop(){
        while(true){
            string choice = "";
            if (choice == "A"){
                Console.WriteLine("Yeah Man!");
            }
            else if (choice == "B"){
                Console.WriteLine("Not Good Man");
            }
            else if (choice == "C"){
                Console.WriteLine("Idk Man");
            }
        }
    }
}