using CustomException;

namespace SimpleException;

public class Car
{
    public const int MaxSpeed = 100;

    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = String.Empty;

    private bool _carIsDead;
    private readonly Radio _theMusicBox = new Radio();
    
    public Car(){}

    public Car(string name, int speed)
    {
        CurrentSpeed = speed;
        PetName = name;
    }

    public void CrankTunes(bool state)
    {
        _theMusicBox.TurnOn(state);
    }

    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            Console.WriteLine($"{PetName} is out of order...");
        }
        else
        {
            CurrentSpeed += delta;
            if (CurrentSpeed > MaxSpeed)
            {
                CurrentSpeed = 0;
                _carIsDead = true;
                throw new CarIsDeadException($"{PetName} has overheated!", "You have a lead foot", DateTime.Now)
                {
                    HelpLink = "http://www.CarsUrl.com",
                    Data =
                    {
                        { "TimeStamp", $"The car exploded at {DateTime.Now}" },
                        { "Cause", "You have a lead foot." }
                    }
                };
            }
            else
            {
                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}