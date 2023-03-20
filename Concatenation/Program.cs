// See https://aka.ms/new-console-template for more information



string firstSymbol = "$$";
string lastSymbol = "USD";
int benjamin = 100;
string wallet = string.Concat(firstSymbol + " " + benjamin + " " + lastSymbol); //why did the plus sign work but not comma?
Console.WriteLine(wallet);