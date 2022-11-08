using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Fun with LINQ to Objects");
//QueryOverStrings();
QueryOverStringsWithExtensionMethods();
QueryOverInts();

static void QueryOverInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
    IEnumerable<int> subset = from i in numbers where i < 10 select i;

    foreach(int i in subset)    
    {
        Console.WriteLine("Item: {0}", i);
    }
}

static void QueryOverStringsWithExtensionMethods()
{
    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

    IEnumerable<string> subset = 
        currentVideoGames.Where(g => g.Contains(" "))
            .OrderBy(g => g)
            .Select(g => g);

    foreach(string s in subset)        
    {
        Console.WriteLine("Item: {0}", s);
    }
}

static void QueryOverStrings()
{
    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

    IEnumerable<string> subset = 
        from g in currentVideoGames
        where g.Contains(" ")
        orderby g
        select g;

    foreach(string s in subset)        
    {
        Console.WriteLine("Item: {0}", s);
    }
}