using System;
using static System.Console;
using ObjectInitializers;

WriteLine("***** Fun with Object Init Syntax *****\n");

Point firstPoint = new Point();
firstPoint.X = 10;
firstPoint.Y = 10;
firstPoint.DisplayStats();

Point anotherPoint = new Point(20, 20);
anotherPoint.DisplayStats();

Point finalPoint = new Point(10, 20) { X = 30, Y = 30 };
finalPoint.DisplayStats();

Point goldPoint = new Point(PointColorEnum.Gold) { X = 89, Y = 22 };
goldPoint.DisplayStats();

Rectangle myRect = new Rectangle()
{
    TopLeft = new Point { X = 10, Y = 10 },
    BottomRight = new Point { X = 200, Y = 200 }
};


