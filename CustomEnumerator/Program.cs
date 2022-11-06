// See https://aka.ms/new-console-template for more information

using CustomEnumerator;

Console.WriteLine("Fun with IEnumerable / IEnumerator");
Garage carLot = new();

foreach (var car in carLot)
{
    car.DisplayStats();
}
