namespace Empmoyees;

public record MiniVan(string Make, string Model, string Color, int Seating) : Car(Make, Make, Color);
