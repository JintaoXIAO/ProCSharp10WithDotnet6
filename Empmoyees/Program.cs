// See https://aka.ms/new-console-template for more information

using Empmoyees;

Console.WriteLine("The Employee Class Hierarchy");
SalesPerson fred = new SalesPerson
{
    Age = 31, Name = "Fred", SalesNumber = 50
};

Car c = new Car("BMW", "Blue", "M8");
MiniVan miniVan = new MiniVan("BENZ", "GRAY", "S450", 4);

Console.WriteLine($"Checking MiniVan is-a Car: {miniVan is Car}");

PositionalCar pc = new PositionalCar("Honda", "Pilot", "Blue");
PositionalMinivan pm = new PositionalMinivan("Honda", "Pilot", "Blue", 10);
Console.WriteLine($"Checking PoistionalMiniVan is-a PositionalCar:{pm is PositionalCar}");

MotorCycle mc = new FancyScooter("Harley", "Lowrider", "Gold");
Console.WriteLine($"mc is a FancyScooter: {mc is FancyScooter}");

var (make1, model1, color) = (FancyScooter)mc;


Console.WriteLine("***** The Employee Class Hierarchy *****");
Employee chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2222", 8000);
chucky.DisplayStats();

Employee fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 32);
fran.DisplayStats();
