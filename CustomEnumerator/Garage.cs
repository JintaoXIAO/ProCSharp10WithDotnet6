using System.Collections;

namespace CustomEnumerator;

public class Garage : IEnumerable<Car>
{
    private Car[] _cars = new Car[4];

    public Garage()
    {
        _cars[0] = new Car() { PetName = "Blue", Color = "Rusty", Speed = 30 };
        _cars[1] = new Car() { PetName = "Clunker", Color = "Green", Speed = 55 };
        _cars[2] = new Car() { PetName = "Zippy", Color = "Yellow", Speed = 30 };
        _cars[3] = new Car() { PetName = "Fred", Color = "Red", Speed = 30 };
    }

    public IEnumerator<Car> GetEnumerator()
    {
        foreach (var car in _cars)
        {
            yield return car;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}