namespace GeoShapesLib;

/// <summary>
/// Интерфейс, который определяет общий контракт для всех фигур в библиотеке.
/// Он гарантирует, что все фигуры будут иметь метод CalculateArea, который вычисляет их площадь.
/// </summary>
public interface IShape
{
    double CalculateArea();
}