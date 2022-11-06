using System.Collections;
using CustomException;
using SimpleException;;

Console.WriteLine("***** Simple Exception Example *****");
Console.WriteLine("=> Creating a car and stepping on it!");
Car myCar = new("Zippy", 20);
myCar.CrankTunes(true);

try
{
    for (int i = 0; i < 10; i++)
    {
        myCar.Accelerate(10);
    }

}
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ErrorTimeStamp);
    Console.WriteLine(e.CauseOfError);
    
}
