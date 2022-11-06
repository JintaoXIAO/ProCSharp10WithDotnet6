namespace CarDelegate;

public class Car
{
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; } = 100;
    public string PetName { get; set; }

    private bool _carIsDead;

    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            _listOfHandler?.Invoke("Sorry, this car is dead...");
        }
        else
        {
            CurrentSpeed += delta;
            if (10 == (MaxSpeed - CurrentSpeed))
            {
                _listOfHandler?.Invoke("Careful buddy! Gonna blow!");
            }

            if (CurrentSpeed >= MaxSpeed)
            {
                _carIsDead = true;
            }
            else
            {
                Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
            }
        }
    }

    public Car()
    {
    }

    public Car(string name, int maxSp, int currSp)
    {
        CurrentSpeed = currSp;
        MaxSpeed = maxSp;
        PetName = name;
    }

    public delegate void CarEngineHandler(string msgForCaller);

    private CarEngineHandler _listOfHandler;

    public void RegisterWithCarEngine(CarEngineHandler handler)
    {
        _listOfHandler = Delegate.Combine(_listOfHandler, handler)
            as CarEngineHandler;
    }
}