// See https://aka.ms/new-console-template for more information

using CustomGenericMethods;

Console.WriteLine("Hello, World!");
int a = 10, b = 89;
Console.WriteLine($"Before swap, a={a}, b={b}");
SwapFunctions.Swap(ref a, ref b);
Console.WriteLine($"After swap, a={a}, b={b}");
DisplayBaseClass<int>();
DisplayBaseClass<string>();

static void DisplayBaseClass<T>()
{
    Console.WriteLine("Base class of {0} is: {1}.", typeof(T), typeof(T).BaseType);
}