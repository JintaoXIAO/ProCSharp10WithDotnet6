using static System.Console;

namespace AutoProps;

public class Car
{
    public string PetName { get; set; }
    public int Speed { get; set; }
    public string Color { get; set; }

    public void DisplayStats()
    {
        WriteLine("Car Name: {0}", PetName);
        WriteLine("Speed: {0}", Speed);
        WriteLine("Color: {0}", Color);
    }
}