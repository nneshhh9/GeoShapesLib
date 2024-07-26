namespace GeoShapesLib;

/// <summary>
/// Класс позволяет вычислять площадь любой фигуры, реализующей интерфейс IShape, без необходимости знать конкретный тип фигуры во время компиляции
/// </summary>
public class ShapeAreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        // IShape circle = new Circle(5);
        // IShape triangle = new Triangle(3, 4, 5);
        //
        // double circleArea = ShapeAreaCalculator.CalculateArea(circle);
        // double triangleArea = ShapeAreaCalculator.CalculateArea(triangle);
        
        return shape.CalculateArea();
    }
}