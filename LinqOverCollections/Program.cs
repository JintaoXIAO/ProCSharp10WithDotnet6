using System;
using LinqOverCollections;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("LINQ over Generic Collections");
List<Car> myCars = new List<Car>() 
{
    new Car { PetName = "Henry", Color = "Silver", Speed = 10, Make = "BMW" },
    new Car { PetName = "Diasy", Color = "Tan", Speed = 90, Make = "BMW" },
    new Car { PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
    new Car { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
    new Car { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" },
};

GetFashCars(myCars);


static void GetFashCars(List<Car> myCars)
{
    var fastCars = from c in myCars where c.Speed > 55 select c;
    foreach(var car in fastCars)
    {
        Console.WriteLine($"{car.PetName} is going too fast");
    }
}