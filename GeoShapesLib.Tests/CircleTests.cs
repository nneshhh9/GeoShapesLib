namespace GeoShapesLib.Tests;

public class CircleTests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void CalculateArea_ShouldReturnCorrectArea()
    {
        double radius = 5;
        Circle circle = new Circle(radius);
        double expectedArea = Math.PI * radius * radius;

        double actualArea = circle.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea, 1e-5);
    }
}