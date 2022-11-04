using static System.Console;
using FunWithRecords;

WriteLine("Fun with Records!");

Car myCar = new Car
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue",
};

WriteLine("My car: ");
DisplayCarStats(myCar);

Car anotherMyCar = new("Honda", "Pilot", "Blue");
WriteLine("Another variable for my car: ");
DisplayCarStats(anotherMyCar);

static void DisplayCarStats(Car c)
{
    WriteLine("Car Make: {0}", c.Make);
    WriteLine("Car Model: {0}", c.Model);
    WriteLine("Car Color: {0}", c.Color);
}



CarRecord myCarRecord = new CarRecord("Honda","Pilot", "Blue");

WriteLine("My car: ");
DisplayCarRecordStats(myCarRecord);
WriteLine(myCarRecord);
myCarRecord.Deconstruct(out string make, out string modle, out string color);

var (make2, model2, color2) = myCarRecord;

CarRecord carRecordCopy = myCarRecord with { Model = "Odyssey" };

static void DisplayCarRecordStats(CarRecord c)
{
    WriteLine("Car Make: {0}", c.Make);
    WriteLine("Car Model: {0}", c.Model);
    WriteLine("Car Color: {0}", c.Color);
}
