using System;

namespace SimpleClassExample;

public class Motorcycle
{
    public int driverIntensity;
    public string driverName;

    public void SetDriverName(string name) => this.driverName = name;
    
    public void PopAWheely()
    {
        for (int i = 0; i < driverIntensity; i++)
        {
            Console.WriteLine("Yeeeeeeeee Haaaaaaaaawww!");
        }
    }

    public Motorcycle() : this(0){}

    public Motorcycle(int intensity) : this(intensity, string.Empty) {}

    public Motorcycle(int intensity = 10, string name = "")
    {
        if (intensity > 10)
        {
            intensity = 10;
        }

        driverIntensity = intensity;
        driverName = name;
    }

    public override string ToString() => $"Name= {driverName}, Intensity= {driverIntensity}";
}