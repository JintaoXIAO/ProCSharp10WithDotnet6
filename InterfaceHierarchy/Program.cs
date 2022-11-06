using InterfaceHierarchy;

Console.WriteLine("Simple Interface Hierarchy");

BitmapImage image = new();
image.Draw();
image.DrawUpsideDown();
image.DrawInBoundingBox(10, 10, 40, 50);
Console.WriteLine((image as IDrawable).TimeToDraw());
Console.WriteLine((image as IAdvancedDraw).TimeToDraw());

