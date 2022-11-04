using System;
using SimpleClassExample;

Console.WriteLine("***** Fun with Class Types *****\n");
MakeSomeBikes();

static void MakeSomeBikes()
{
    Motorcycle m1 = new();
    Console.WriteLine(m1);

    Motorcycle m2 = new(name: "Tiny");
    Console.WriteLine(m2);

    Motorcycle m3 = new(7);
    Console.WriteLine(m3);
}