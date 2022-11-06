namespace MiInterfaceHierarchy;

public class Rectangle : IShape
{
    public void Print() => Console.WriteLine("Printing...");
    
    void IPrintable.Draw() => Console.WriteLine("Draw to printer...");
    
    public int GetNumberOfSides() => 4;
    
    void IDrawable.Draw() => Console.WriteLine("Draw to screen...");
}