// See https://aka.ms/new-console-template for more information
using Shapes;

Console.WriteLine("***** Fun with Polymorphism *****\n");
Shape hex = new Hexagon("Beth");
hex.Draw();

Shape cir = new Circle("Cindy");
cir.Draw();

ThreeDCircle o = new ThreeDCircle();
o.Draw();
((Circle)o).Draw();

object[] things = new object[] { new Hexagon(), false, "Last thing" };
foreach (object item in things)
{
    Hexagon h = item as Hexagon;
    if (h == null)
    {
        Console.WriteLine("Item is not a hexagon");
    }
    else
    {
        h.Draw();
    }
}