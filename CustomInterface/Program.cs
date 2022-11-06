// See https://aka.ms/new-console-template for more information

using CustomInterface;

Console.WriteLine("***** Fun with Interfaces *****\n");
var sq = new Square("Boxy")
    { NumberOfSides = 4, SideLength = 4 };
sq.Draw();    

Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of Length {sq.SideLength} and a perimeter of {(sq as IRegularPointy).Perimeter}");