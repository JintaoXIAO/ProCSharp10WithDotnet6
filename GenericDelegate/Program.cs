// See https://aka.ms/new-console-template for more information

Console.WriteLine("Generic Delegates");

MyGenericDelegate<string> strTarget = StringTarget;
strTarget("hello world");

Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
actionTarget("Action Message!", ConsoleColor.Cyan, 5);

Func<int, int, int> funcTarget = Add;

static int Add(int x, int y)
{
    return x + y;
}

static void StringTarget(string arg)
{
    Console.WriteLine("arg in uppercase is {0}", arg.ToUpper());
}

static void IntTarget(int arg)
{
    Console.WriteLine("arg is {0}", arg);
}

static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
{
    ConsoleColor previous = Console.ForegroundColor;
    Console.ForegroundColor = txtColor;
    for (int i = 0; i < printCount; i++)
    {
        Console.WriteLine(msg);
    }
    Console.ForegroundColor = previous;
    
}

public delegate void MyGenericDelegate<T> (T arg);