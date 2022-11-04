namespace FunWithRecords;

public class Car
{
  public string Make { get; set; }
  public string Model { get; set; }
  public string Color { get; set; }

  public Car() {}
  public Car(string make, string model, string color)
  {
    Make = make;
    Model = model;
    Color = color;
  }
}