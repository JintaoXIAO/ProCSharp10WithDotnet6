namespace CarEvents;

public class Car
{
    private bool _carIsDead;
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; } = 55;
    
    public event EventHandler<string> Exploded;
    public event EventHandler<string> AboutToBlow;

    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            Exploded?.Invoke(this, "Sorry, this car is dead...");
        }
        else
        {
            CurrentSpeed += delta;
            if (10 == MaxSpeed - CurrentSpeed)
            {
                AboutToBlow?.Invoke(this, "Careful buddy! Gonna blow@");
            }

            if (CurrentSpeed >= MaxSpeed)
            {
                _carIsDead = true;
            }
            else
            {
                Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}