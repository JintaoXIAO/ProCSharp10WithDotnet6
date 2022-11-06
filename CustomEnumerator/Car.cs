using static System.Console;

namespace CustomEnumerator;

public class Car
{
    public string PetName { get; set; }
    public int Speed { get; set; }
    public string Color { get; set; }

    public void DisplayStats()
    {
        WriteLine("Car Name: {0}, Speed: {1}, Color: {2}", PetName, Speed, Color);
    }
}