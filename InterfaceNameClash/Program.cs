using InterfaceNameClash;

Console.WriteLine("Fun with Inteface Name Clashes");
Octagon oct = new();

(oct as IDrawToForm).Draw();
(oct as IDrawToMemory).Draw();