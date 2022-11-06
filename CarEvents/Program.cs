// See https://aka.ms/new-console-template for more information

using CarEvents;

Console.WriteLine("Fun with Events");

Car c1 = new Car();
c1.AboutToBlow += CarIsAlmostDoomed;
c1.AboutToBlow += CarAboutToBlow;

EventHandler<string> d = CarExploded;
c1.Exploded += d;

for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}

c1.Exploded -= d;

for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}

static void CarAboutToBlow(object? sender, string msg)
{
    Console.WriteLine($"msg :{msg} from {sender}");
}

static void CarIsAlmostDoomed(object? sender, string? msg)
{
    Console.WriteLine("=> Critical Message: {0} from Car: {1}", msg, sender);
}

static void CarExploded(object? sender,string msg)
{
    Console.WriteLine($"msg: {msg} from {sender}");
}