namespace Empmoyees;

public record PositionalCar(string Make, string Model, string Color);

public record PositionalMinivan(string Make, string Model, string Color, int Seating)
    : PositionalCar(Make, Model, Color);

public record MotorCycle(string Make, string Model);

public record Scooter(string Make, string Model) : MotorCycle(Make, Model);

public record FancyScooter(string Make, string Model, string FancyColor)
    : Scooter(Make, Model);
