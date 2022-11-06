namespace GenericPoint;

public class Point<T>
{
    public T X { get; set; } = default;
    public T Y { get; set; } = default;
    
    public override string ToString() => $"[{X}, {Y}]";
}