namespace GeoShapesLib;

/// <summary>
/// Класс представляет круг и реализует интерфейс IShape.
/// Содержит свойства и методы, специфичные для круга, такие как вычисление площади на основе радиуса.
/// </summary>
public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}