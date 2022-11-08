using System;
using System.Collections.Generic;

Console.WriteLine("Fun with lambdas");
TraditionalDelegateSyntax();
LambdaExpressionSyntax();


static void TraditionalDelegateSyntax()
{
    List<int> list = new List<int>();    
    list.AddRange(new int[] { 20, 1, 5, 8, 9, 44 });

    Predicate<int> callback = IsEvenNumber;
    List<int> evenNumbers = list.FindAll(delegate(int i) {return (i % 2) == 0;});

    Console.WriteLine("Here are your even numbers");
    foreach(int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
    Console.WriteLine();
}

static bool IsEvenNumber(int i)
{
    return (i % 2) == 0;
}

static void LambdaExpressionSyntax()
{
    List<int> list = new List<int>();
    list.AddRange(new int[] { 20, 1, 44, 9, 3, 8});
    List<int> evenNumbers = list.FindAll(i => i % 2 == 0);
    Console.WriteLine("Here are your even numbers");
    foreach(int e in evenNumbers)
    {
        Console.WriteLine(e);
    }
}