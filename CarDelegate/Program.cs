using CarDelegate;

Console.WriteLine("Delegates as event enables");

Car c1 = new Car();
Console.WriteLine("Speeding up");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}


static void OnCarEngineEvent(string msg)
{
    Console.WriteLine("Message From Car Object");
    Console.WriteLine("=> {0}", msg);
    Console.WriteLine("********************");
}

c1.RegisterWithCarEngine(OnCarEngineEvent);