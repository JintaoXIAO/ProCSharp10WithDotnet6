// See https://aka.ms/new-console-template for more information

using SimpleDelegate;

Console.WriteLine("Simple Delegate Example");
BinaryOp b = new BinaryOp(SimpleMath.Add);
int r = b(10, 10);
Console.WriteLine(r);

public delegate int BinaryOp(int x, int y);