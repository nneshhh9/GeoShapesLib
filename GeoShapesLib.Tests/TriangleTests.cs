namespace GeoShapesLib.Tests;

public class TriangleTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void CalculateArea_ShouldReturnCorrectArea()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        double expectedArea = 6;

        double actualArea = triangle.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea, 1e-5);
    }

    [Test]
    public void IsRightTriangle_ShouldReturnTrueForRightTriangle()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        bool isRightTriangle = triangle.IsRightTriangle();

        Assert.IsTrue(isRightTriangle);
    }

    [Test]
    public void IsRightTriangle_ShouldReturnFalseForNonRightTriangle()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 6;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        bool isRightTriangle = triangle.IsRightTriangle();

        Assert.IsFalse(isRightTriangle);
    }
}